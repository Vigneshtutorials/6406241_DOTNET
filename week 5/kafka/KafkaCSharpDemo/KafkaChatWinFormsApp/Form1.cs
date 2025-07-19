using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaChatWinFormsApp
{
    public partial class Form1 : Form
    {
        private IProducer<Null, string> producer;
        private IConsumer<Ignore, string> consumer;
        private CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
            SetupKafka();
            StartConsumer();
        }

        private void SetupKafka()
        {
            var prodConfig = new ProducerConfig { BootstrapServers = "localhost:9092" };
            producer = new ProducerBuilder<Null, string>(prodConfig).Build();

            var consConfig = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = Guid.NewGuid().ToString(),
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            consumer = new ConsumerBuilder<Ignore, string>(consConfig).Build();
            consumer.Subscribe("chat-topic");
        }

        private void StartConsumer()
        {
            cts = new CancellationTokenSource();
            Task.Run(() =>
            {
                try
                {
                    while (!cts.Token.IsCancellationRequested)
                    {
                        var msg = consumer.Consume(cts.Token);
                        Invoke(new Action(() =>
                        {
                            lstChat.Items.Add($"Friend: {msg.Message.Value}");
                        }));
                    }
                }
                catch (OperationCanceledException) { }
            }, cts.Token);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text.Trim();
            if (!string.IsNullOrEmpty(msg))
            {
                await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = msg });
                lstChat.Items.Add($"You: {msg}");
                txtMessage.Clear();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cts?.Cancel();
            consumer?.Close();
            producer?.Dispose();
            consumer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
