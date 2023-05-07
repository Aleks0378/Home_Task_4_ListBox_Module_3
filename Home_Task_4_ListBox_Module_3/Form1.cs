using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Home_Task_4_ListBox_Module_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        List<Human> list = new List<Human>();

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Clear();
            Download_from_file();
            //Human h1 = new Human("Mark","Goodman","markgoodman@yahoo.com",+4058245638);
            //Human h2 = new Human("Ugen", "Macintosh", "ugenmac@gmail.com", +1055275930);
            //Human h3 = new Human("Sergii", "Ledyanik", "goodledyanik@yahoo.com", +380674567545);

            //list.Add(h1);
            //list.Add(h2);
            //list.Add(h3);

            //foreach (var item in list)
            //{
            //    listBox1.Items.Add(item);
            //}

        }
        public void Reset()
        {
            name.Text = String.Empty;
            surname.Text = String.Empty;
            mail.Text = String.Empty;
            phone.Text = String.Empty;
        }

        public void Save_to_file()
        {
            foreach (var item in listBox1.Items)
            {
                list.Add((Human)item);
            }
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Human>));
            try
            {
                using (Stream fStream = File.OpenWrite("Form1_2.xml"))
                {
                    xmlFormat.(fStream, list);
                }
                MessageBox.Show("Список сохранен в файл", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Download_from_file()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Human>));
            try
            {
                using (Stream fStream = File.OpenRead("Form1_2.xml"))
                {
                    list = (List<Human>)xmlFormat.Deserialize(fStream);
                }
               foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            Human add_item = new Human(name.Text,surname.Text,mail.Text,float.Parse(phone.Text));
            listBox1.Items.Add(add_item);
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали позицию");
                return;
            }
            but_delete.Enabled = true;
            but_edit.Enabled = true;          
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            //int index = listBox1.SelectedIndex;
            //if (index != -1)
            //{
            //    listBox1.Items.RemoveAt(index);
            //}
            if (this.listBox1.Items.Count != 0)
            {
                    for (int i = 0; i < this.listBox1.
                    SelectedItems.Count; i++)
                    {
                        this.listBox1.Items.Remove(this.listBox1.SelectedItems[i]);
                    }
            }
            but_delete.Enabled = false;
            but_edit.Enabled = false;
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;//запоминаем выделенный элемент
            Human h = new Human();
            h=(Human)listBox1.Items[n];
            name.Text = h.name;
            surname.Text = h.surname;
            mail.Text = h.mail;
            phone.Text = h.phone.ToString();
            listBox1.Items.RemoveAt(n);//Удаляем выделенный элемент
            but_edit.Enabled=false;
            but_delete.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_to_file();
        }
    }


    public class Human
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public float phone { get; set; }

        public Human()
        {
            name = null;
            surname=null;
            mail=null;
            phone=0;
        }

        public Human(string name, string surname, string mail, float phone)
        {
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.phone = phone;
        }

        //public Human(Human x)
        //{
        //    this.name = x.name;
        //    this.surname = x.surname;
        //    this.mail = x.mail;
        //    this.phone = x.phone;
        //}
        public override string ToString()
        {
            return $"Name = {name}, Surname = {surname}";
        }
    }
}
