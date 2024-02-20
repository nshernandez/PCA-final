using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCA_final
{
    public partial class Form3 : Form
    {
        public class item
        {
            public string Nombre { get; set; }
            public float Precio { get; set; }
            public int Cantidad { get; set; }

            public item(string nombre, float precio, int cantidad)
            {
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;

            }

            internal void Add(item item)
            {
                throw new NotImplementedException();
            }
        }
        public class tienda
        {
            public string Nombre { get; set; }
            public List<item> items { get; set; }

            public tienda(string nombre, List<item> items)
            {
                Nombre = nombre;
                this.items = items;
            }
        }
        public class Carrito
        {
            public List<item> items { get; private set; }
            public Carrito()
            {
                items = new List<item>();
            }
        }
        public void Additem(item item)
        {
            item.Add(item);

        }

        private Carrito carrito = new();

        private BindingList<Form2.Cliente> clientes = new BindingList<Form2.Cliente>();
        private List<tienda> tiendas = new();

        public Form3()
        {
            InitializeComponent();

            tiendas.Add(new tienda("Nike", new List<item> { new item("Zapatos", 100, 15), new item("franelas", 50, 15), }));
            tiendas.Add(new tienda("Adidas", new List<item> { new item("Zapatos", 100, 15), new item("franelas", 50, 15) }));
            tiendas.Add(new tienda("Multimax", new List<item> { new item("Nevera", 1000, 15), new item("Lavadora", 500, 15) }));
            tiendas.Add(new tienda("Samsung", new List<item> { new item("Celular", 1000, 15), new item("Tablet", 500, 15) }));
            tiendas.Add(new tienda("Timberland", new List<item> { new item("Botas", 100, 15), new item("franelas", 50, 15) }));
            tiendas.Add(new tienda("Shoe Box Store", new List<item> { new item("Zapatos", 20, 15), new item("Sweater", 30, 15) }));
            tiendas.Add(new tienda("Balu Hogar", new List<item> { new item("Almohada", 30, 15), new item("Sabana", 100, 15) }));
            tiendas.Add(new tienda("Mcdonald's", new List<item> { new item("Hamburguesa", 5, 100), new item("Papas", 3, 100) }));
            tiendas.Add(new tienda("KFC", new List<item> { new item("Pollo", 10, 100), new item("Papas", 3, 100) }));
            tiendas.Add(new tienda("Pizza mia", new List<item> { new item("Pizza", 10, 100), new item("Papas", 3, 100) }));
            tiendas.Add(new tienda("Cinex", new List<item> { new item("Combo de cotufas", 15, 45), new item("Entrada", 3, 45) }));
            tiendas.Add(new tienda("Sigo", new List<item> { new item("Leche", 5, 100), new item("Huevos", 3, 100) }));
            tiendas.Add(new tienda("FarmaSigo", new List<item> { new item("Pastillas", 5, 100), new item("Jarabe", 3, 100) }));
            tiendas.Add(new tienda("IronMarket", new List<item> { new item("Proteina", 50, 100), new item("Creatina", 35, 100) }));
            tiendas.Add(new tienda("GNC", new List<item> { new item("Proteina", 50, 100), new item("Creatina", 35, 100) }));




            foreach (var tienda in tiendas)
            {
                comboBox1.Items.Add(tienda.Nombre);

            }


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tienda = tiendas.FirstOrDefault(t => t.Nombre == comboBox1.SelectedItem.ToString());

            if (tienda != null)
            {
                foreach (var item in tienda.items)
                {
                    comboBox2.Items.Add(item.Nombre);
                    comboBox3.Items.Add(item.Nombre);
                }
            }

            for (int i = 0; i < tienda.items.Count; i++)
            {
                item? item = tienda.items[i];
                comboBox2.Items.Add(item.Nombre);
                item? item2 = tienda.items[i];  
                comboBox3.Items.Add(item2.Nombre);  

               
            }


        }

        private void buttonComprar_Click1(object sender, EventArgs e)
        {
            var tienda = tiendas.FirstOrDefault(t => t.Nombre == comboBox1.SelectedItem.ToString());

            var selectedItem = tienda.items.FirstOrDefault(i => i.Nombre == comboBox2.SelectedItem.ToString()); 

            if (selectedItem != null)
            {
                int cantidad = (int)numericUpDown1.Value;   

                item itemAComprar = new item(selectedItem.Nombre, selectedItem.Precio, cantidad);

                carrito.items.Add(itemAComprar);

                MessageBox.Show("Item agregado al carrito");
                
                
            }




            }
        }
    }



        
        

        
    



