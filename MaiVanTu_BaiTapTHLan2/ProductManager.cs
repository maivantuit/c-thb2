using System;
using System.Collections.Generic;

namespace MaiVanTu_BaiTapTHLan2
{    
    class Product
    {
        // fields:
        private int id;
        private string name;
        private int price;
        private int quantity;
        public static int record = 0;
        // properties:
        public int ID
        {
            set
            {
                this.id = value;
            }
            get
            {
                return id;
            }
        }
        public string NAME
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public int PRICE
        {
            set
            {
                this.price = value;
            }
            get
            {
                return price;
            }
        }
        public int QUANTITY
        {
            set;
            get;
        }
        // constructor:
        public Product() { }
        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Product(int id, string name,int gia, int soluong):this(id, name)
        {
            this.price = gia;
            this.quantity = soluong;
        }
        // methods input and ouput:
        public void Input()
        {
            try
            {
                Console.WriteLine("Input id:");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("error input!");
            }
            Console.Write("Input name: ");
            name = Console.ReadLine();            
            try
            {
                Console.WriteLine("Input price: ");
                price = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input quatity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("error input!");
            }
        }
        public void Ouput()
        {
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", ++(Product.record), id, name, price, quantity);
        }
    }
    class ProductManager
    {
        static void Main(string[] args)
        {
            int[] Arrayn = null;
            List<Product> listproduct = new List<Product>();
            int n;
            int luachon = 0;
            do
            {
                Console.WriteLine("------------THC# times II ------------");
                Console.WriteLine("1. Add a list products");
                Console.WriteLine("2. Add products");
                Console.WriteLine("3. Remove produts");
                Console.WriteLine("4. Remove products by index");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please, input chooce: ");
                luachon = Convert.ToInt32(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        {
                            Console.Write("How many items do you want to add?: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            Arrayn = new int[n];
                            for (int i = 0; i < Arrayn.Length; i++)
                            {
                                Console.WriteLine("input product number {0}", i + 1);
                                Product p = new Product();
                                p.Input();
                                listproduct.Add(p);
                            }
                            Console.WriteLine("Products added: ");
                            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}","recordinput" ,"id","Name product","price", "Quatity");
                            for (int i = 0; i < listproduct.Count; i++)
                            {
                                listproduct[i].Ouput();
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("input info product need add: ");
                            for (int i = 0; i < 1; i++)
                            {
                                Product p = new Product();
                                p.Input();
                                listproduct.Add(p);
                            }
                            Console.WriteLine("Products after later when add: ");
                            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", "recordinput", "id", "Name product", "price", "Quatity");
                            for (int i = 0; i < listproduct.Count; i++)
                            {
                                listproduct[i].Ouput();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Input name product need delete: ");
                            string prodel;
                            int dem = 0;
                            prodel = Console.ReadLine();
                            for (int i = 0; i < listproduct.Count; i++)
                            {
                                if (prodel.Equals(listproduct[i].NAME))// so sánh name prodel with namepro have in listproduct
                                {
                                    listproduct.Remove(listproduct[i]);
                                    dem++;
                                }
                            }
                            if (dem == 0)
                            {
                                Console.WriteLine("not have products that you find!");
                            }
                            Console.WriteLine("Products after delete later(remove): ");
                            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", "recordinput", "id", "Name product", "price", "Quatity");
                            for (int i = 0; i < listproduct.Count; i++)
                            {
                                listproduct[i].Ouput();
                            }
                        }
                        break;
                    case 4:
                        {
                            int index=0;
                            Console.WriteLine("Input index: ");
                            index = Convert.ToInt32(Console.ReadLine());
                            if (index < 0 && index > listproduct.Count)
                            {
                                Console.WriteLine("Not products same as in listproduct");
                            }
                            listproduct.RemoveAt(index);
                            Console.WriteLine("Products after delete later(remove): ");
                            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15}", "recordinput", "id", "Name product", "price", "Quatity");
                            for (int i = 0; i < listproduct.Count; i++)
                            {
                                listproduct[i].Ouput();
                            }
                        }
                        break;
                    case 5:
                        {
                            System.Environment.Exit(1);
                        }
                        break;

                }
            } while (luachon != 5);
        }
    }
}
