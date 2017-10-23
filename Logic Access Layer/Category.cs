using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_access_layer
{
    class Category
    {
    List<Category> categories = new List<Category>
            {
                new Category ("Hälsa"),
                new Category ("Programmering"),
                new Category ("Vetenskap")
            };

        public Category(string kategori)
            {
                Kategori = kategori;
            }

            public string Kategori { get; set; }

            public override string ToString()
            {
                return Kategori.ToString();
            }



   

            
}
}

