using Store.Payment;
using Store.Product;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Поставщики
            Store.Supplier.Supplier apple = new Store.Supplier.Supplier("Apple Inc.");
            Store.Supplier.Supplier steam = new Store.Supplier.Supplier("Steam");
            Store.Supplier.Supplier samsung = new Store.Supplier.Supplier("Samsung Electronics");

            // Конкретные продукты
            Electronics iphone = new Electronics("iPhone 15", "A2894", 120000, apple, 24);
            Electronics laptop = new Electronics("MacBook Air", "M2", 140000, apple, 36);
            DigitalProduct game = new DigitalProduct("Cyberpunk 2077", 4000, steam, "CP77-KEY-1234");

            // Создание заказа
            Store.Order.Order order = new Store.Order.Order();
            order.AddProduct(iphone);
            order.AddProduct(laptop);
            order.AddProduct(game);

            // Вывод заказа
            order.DisplayOrder();

            // Выбор способа оплаты
            IPayment paymentMethod = new CreditCardPayment("1234-5678-9876-5432");
            Store.Payment.Payment payment = new Store.Payment.Payment(order, paymentMethod);

            // Завершение оплаты
            payment.CompletePayment();
        }
    }
}
