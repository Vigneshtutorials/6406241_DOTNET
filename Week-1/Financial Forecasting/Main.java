import java.util.Scanner;

public class Main {
    public static double forecastValue(double p, double r, int y) {
        if (y == 0) {
            return p;
        }
        return forecastValue(p, r, y - 1) * (1 + r);
    }

    public static void main(String args[]) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the initial amount:");
        double amount = sc.nextDouble();
        System.out.println("Enter the initial rate:");
        double rate = sc.nextDouble();
        System.out.println("Enter no.of years:");
        int year = sc.nextInt();

        double forecastval = forecastValue(amount, rate, year);
        System.out.println(forecastval);
        sc.close();
    }

}