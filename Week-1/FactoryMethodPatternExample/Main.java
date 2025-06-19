interface Document {
    void type();
}

class WordDocument implements Document {
    public void type() {
        System.out.println("It's a WordDocument...");
    }
}

class PdfDocument implements Document {
    public void type() {
        System.out.println("It's a PdfDocument...");
    }
}

class ExcelDocument implements Document {
    public void type() {
        System.out.println("It's a ExcelDocument...");
    }
}

class DocumentFactory {
    public Document createDocument(String type) {
        if (type.equalsIgnoreCase("worddocument")) {
            return new WordDocument();
        }
        if (type.equalsIgnoreCase("pdfdocument")) {
            return new PdfDocument();
        }
        if (type.equalsIgnoreCase("exceldocument")) {
            return new ExcelDocument();
        }
        return null;
    }
}

public class Main {
    public static void main(String args[]) {
        DocumentFactory factory = new DocumentFactory();
        Document word = factory.createDocument("worddocument");
        Document pdf = factory.createDocument("pdfdocument");
        Document excel = factory.createDocument("exceldocument");
        if (word != null)
            word.type();
        if (pdf != null)
            pdf.type();
        if (excel != null)
            excel.type();
    }
}