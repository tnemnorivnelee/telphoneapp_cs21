using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp
{
    public partial class MainForm : Form
    {
        People pList = new People();
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person per = new Person(txtName.Text, txtPhone.Text);
            pList.Add(per);
            Text = pList.Count.ToString();
            UpdateDisplay();
        }
        private void UpdateDisplay()
        {
            lbDisplay.Items.Clear();
            for(int i = 0; i < pList.Count; ++i)
            {
                lbDisplay.Items.Add(pList[i].ToString());
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public Person(string n = "", string p = "")
            {
                Name = n;
                Phone = p;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Phone: {Phone}";
            }
        }
        public class People
        {
            List<Person> perList = new List<Person>();
            public void Add(Person per)
            {
                perList.Add(per);
            }
            public void AddRange(Person[] parr)
            {
                perList.AddRange(parr);
            }
            public Person this[int idx]
            {
                get { return perList[idx]; }
            }
            public int Count
            {
                get { return perList.Count; }
            }
        }

        
    }
}
