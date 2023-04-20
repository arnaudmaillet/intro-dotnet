using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SiteMaster : MasterPage
    {
        private PersonRepository listPerson;
        protected void Page_Load(object sender, EventArgs e)
        {
            // listPerson = new PersonRepository();

            // var listAllPerson = listPerson.GetAll();
            // listView1.Columns.Add("ID", 200);
            // listView1.Columns.Add("FirstName", 200);
            // listView1.Columns.Add("LastName", 200);
            // listView1.Columns.Add("Age", 200);

            // LoadData(listAllPerson);
        }

        private void LoadData(IEnumerable<Person> list)
        {
            // foreach (Person person in list)
            // {
            //     ListViewItem item = new ListViewItem(person.PersonId.ToString());
            //     item.SubItems.Add(person.FirstName);
            //     item.SubItems.Add(person.LastName);
            //     item.SubItems.Add(person.Age.ToString());
            //     listView1.Items.Add(item);
            // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listPerson.Create("Corentin", "Lebarilier", 21);


            // foreach (Person person in listPerson.GetAll())
            // {
            //     Debug.WriteLine(person.FirstName);
            // }

            // LoadData(listPerson.GetAll());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if (listView1.SelectedItems.Count > 0)
            // {
            //     ListViewItem selectedItem = listView1.SelectedItems[0];
            //     var selectedValue = selectedItem.Text;
            //     listPerson.Delete(selectedValue);
            // }
        }
    }
}









// using DataProvider;
// using System.Diagnostics;
// using System.Windows.Forms;

// namespace WinFormsApp
// {
//     public partial class Form1 : Form
//     {
//         private PersonRepository listPerson;
//         public Form1()
//         {
//             InitializeComponent();
//         }

//         private void Form1_Load(object sender, EventArgs e)
//         {
//             listPerson = new PersonRepository();

//             var listAllPerson = listPerson.GetAll();
//             listView1.Columns.Add("ID", 200);
//             listView1.Columns.Add("FirstName", 200);
//             listView1.Columns.Add("LastName", 200);
//             listView1.Columns.Add("Age", 200);



//             LoadData(listAllPerson);
//         }

//         private void LoadData(IEnumerable<Person> list)
//         {
//             foreach (Person person in list)
//             {
//                 ListViewItem item = new ListViewItem(person.PersonId.ToString());
//                 item.SubItems.Add(person.FirstName);
//                 item.SubItems.Add(person.LastName);
//                 item.SubItems.Add(person.Age.ToString());
//                 listView1.Items.Add(item);
//             }
//         }

//         private void button1_Click(object sender, EventArgs e)
//         {
//             listPerson.Create("Corentin", "Lebarilier", 21);


//             foreach (Person person in listPerson.GetAll())
//             {
//                 Debug.WriteLine(person.FirstName);
//             }

//             LoadData(listPerson.GetAll());
//         }

//         private void button2_Click(object sender, EventArgs e)
//         {
//             if (listView1.SelectedItems.Count > 0)
//             {
//                 ListViewItem selectedItem = listView1.SelectedItems[0];
//                 var selectedValue = selectedItem.Text;
//                 listPerson.Delete(selectedValue);
//             }
//         }
//     }
// }