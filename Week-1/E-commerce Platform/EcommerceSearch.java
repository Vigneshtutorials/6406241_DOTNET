import java.util.Arrays;
import java.util.Comparator;

public class EcommerceSearch {

    // Product class
    static class Product {
        int productId;
        String productName;
        String category;

        public Product(int productId, String productName, String category) {
            this.productId = productId;
            this.productName = productName;
            this.category = category;
        }

        @Override
        public String toString() {
            return productId + " - " + productName + " [" + category + "]";
        }
    }

    public static Product linearSearch(Product[] products, String name) {
        for (Product p : products) {
            if (p.productName.equalsIgnoreCase(name)) {
                return p;
            }
        }
        return null;
    }

    public static Product binarySearch(Product[] products, String name) {
        int low = 0;
        int high = products.length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;
            int cmp = products[mid].productName.compareToIgnoreCase(name);

            if (cmp == 0) {
                return products[mid];
            } else if (cmp < 0) {
                low = mid + 1;
            } else {
                high = mid - 1;
            }
        }
        return null;
    }

    public static void sortByName(Product[] products) {
        Arrays.sort(products, Comparator.comparing(p -> p.productName.toLowerCase()));
    }

    public static void main(String[] args) {
        Product[] products = {
                new Product(101, "Apple iPhone", "Electronics"),
                new Product(102, "Banana", "Groceries"),
                new Product(103, "Almonds", "Dry Fruits"),
                new Product(104, "Book", "Stationery")
        };

        System.out.println("Linear Search:");
        Product result1 = linearSearch(products, "Banana");
        System.out.println(result1 != null ? result1 : "Product Not Found");

        sortByName(products);
        System.out.println("\nBinary Search:");
        Product result2 = binarySearch(products, "Banana");
        System.out.println(result2 != null ? result2 : "Product Not Found");
    }
}
