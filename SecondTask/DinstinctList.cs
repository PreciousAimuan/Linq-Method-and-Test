using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ20.Net_Week6_Task.SecondTask
{
    public class DinstinctList
    { 
        
            public static List<(int ItemId, string ItemName, int Quantity)> InnerJoin(List<Item> itemlist, List<Sales> saleslist)
            {
                var result = from item in itemlist
                    join sale in saleslist on item.ItemId equals sale.ItemId  // for item in list, when id matches, merge or join to sale
                    select new
                    {
                        ItemId = item.ItemId,
                        ItemName = item.ItemDes,
                        Quantity = sale.Qty
                    };

                return result.Select(x => (x.ItemId, x.ItemName, x.Quantity)).ToList();
            }

            public static void OutputForDistinct()
            {
                List<Item> itemList = new List<Item>
                {
                new Item { ItemId = 1, ItemDes = "Bag" },

                new Item { ItemId = 2, ItemDes = "Pen" },

                new Item { ItemId = 3, ItemDes = "Book " },

                new Item { ItemId = 4, ItemDes = "Shoe " },

                new Item { ItemId = 5, ItemDes = "Pin " }
               
                };

                List<Sales> salesList = new List<Sales>
                {
                new Sales{ InvNo=1, ItemId = 3, Qty = 10 },

                new Sales{ InvNo=2, ItemId = 2, Qty = 20 },

                new Sales{ InvNo=3, ItemId = 3, Qty = 500 },

                new Sales{ InvNo=4, ItemId = 4, Qty = 20 },

                new Sales{ InvNo=5, ItemId = 3, Qty = 100 },

                new Sales{ InvNo=6, ItemId = 1, Qty = 50 }
               
                };

                // Call the InnerJoin method
                List<(int ItemId, string ItemName, int Quantity)> result = DinstinctList.InnerJoin(itemList, salesList);

                // Output the result
                Console.WriteLine("Item ID\t\tItem Name\tQuantity");
                Console.WriteLine("-------------------------------------------");
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.ItemId}\t\t{item.ItemName}\t\t{item.Quantity}");
                }

            }

    }
}
