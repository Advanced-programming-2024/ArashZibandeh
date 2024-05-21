using System;

public class InventoryManagement
{
    public static void Main(string[] args)
    {
        // Read inventory data
        int[][] inventory = ReadInventoryData();

        // Process customer orders
        ProcessCustomerOrders(inventory);
    }

    private static int[][] ReadInventoryData()
    {
        List<int[]> inventoryData = new List<int[]>();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        while (input[0] != -1 && input[1] != -1)
        {
            inventoryData.Add(input);
            input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }

        return inventoryData.ToArray();
    }

    private static void ProcessCustomerOrders(int[][] inventory)
    {
        while (true)
        {
            string[] orderInput = Console.ReadLine().Split(' ');

            if (orderInput[0] == "END")
            {
                break;
            }

            int productCode = int.Parse(orderInput[0]);
            int quantity = int.Parse(orderInput[1]);
            char orderType = Char.ToUpper(orderInput[2][0]);

            ProcessOrder(inventory, productCode, quantity, orderType);
        }
    }

    private static void ProcessOrder(int[][] inventory, int productCode, int quantity, char orderType)
    {
        int productIndex = FindProductIndex(inventory, productCode);

        if (productIndex == -1)
        {
            Console.WriteLine($"Product {productCode} not found in inventory");
            return;
        }

        if (orderType == 'S' && inventory[productIndex][1] < quantity)
        {
            Console.WriteLine($"Insufficient stock for product {productCode}");
            return;
        }

        if (orderType == 'S')
        {
            inventory[productIndex][1] -= quantity;
            Console.WriteLine($"Sold {quantity} units of product {productCode}");
        }
        else if (orderType == 'P')
        {
            inventory[productIndex][1] += quantity;
            Console.WriteLine($"Purchased {quantity} units of product {productCode}");
        }
        else
        {
            Console.WriteLine("Invalid order type");
        }
    }

    private static int FindProductIndex(int[][] inventory, int productCode)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i][0] == productCode)
            {
                return i;
            }
        }

        return -1;
    }
}
