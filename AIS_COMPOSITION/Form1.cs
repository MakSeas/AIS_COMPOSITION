using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_COMPOSITION
{
    public partial class Form1 : Form
    {
        Menu currentMenu=new Menu();
        int categorySelectedIndex;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Menu harryPotterMenu = new Menu("Гарри Поттер");

            Component HP1 = new Book("Гарри Поттер 1", "1 часть легендарного романа про магфак МГУ");
            Component HP2 = new Book("Гарри Поттер 2", "2 часть легендарного романа про магфак МГУ");
            Component HP3 = new Book("Гарри Поттер 3", "3 часть легендарного романа про магфак МГУ");

            harryPotterMenu.AddComponent(HP1);
            harryPotterMenu.AddComponent(HP2);
            harryPotterMenu.AddComponent(HP3);

            Menu metroMenu = new Menu("Метро 2033");

            Component Metro2033 = new Book("Метро 2033", "1 часть постапокалиптического романа за авторством Дмитрия Глуховского");
            Component Metro2034 = new Book("Метро 2034", "2 часть постапокалиптического романа за авторством Дмитрия Глуховского");
            Component Metro2035 = new Book("Метро 2035", "3 часть постапокалиптического романа за авторством Дмитрия Глуховского");

            metroMenu.AddComponent(Metro2033);
            metroMenu.AddComponent(Metro2034);
            metroMenu.AddComponent(Metro2035);

            Menu artLitterature = new Menu("Художественная литература");

            artLitterature.AddComponent(harryPotterMenu);
            artLitterature.AddComponent(metroMenu);

            Component coolFacts = new Book("Прикольные фембой факты", "Мы все дальше от бога");
            Component lizzards = new Book("Русы против ящеров", "Полная энциклопедия войны древних Русов против\nящерской напасти");

            Menu documentaries = new Menu("Документальная литература");

            documentaries.AddComponent(lizzards);
            documentaries.AddComponent(coolFacts);

            Menu mainMenu = new Menu("Главное меню");

            mainMenu.AddComponent(artLitterature);
            mainMenu.AddComponent(documentaries);

            currentMenu = mainMenu;

            CategoryListBox.KeyDown += transfer;
            BookListBox.KeyDown += transfer;

            SetMenu(currentMenu);
        }

        void SetMenu(Menu menu)
        {
            CategoryListBox.Items.Clear();
            BookListBox.Items.Clear();

            if (menu != null)
            {
                foreach (Component position in menu.children)
                {
                    CategoryListBox.Items.Add($"{position.name}");
                }

                if(menu.parrent!=null)
                    CategoryListBox.Items.Add("Вернуться");

                currentMenu = menu;
            }
        }

        void SetMenuList(Menu menu)
        {
            BookListBox.Items.Clear();

            if (menu != null)
            {              
                foreach(Component position in menu.children)
                {
                    BookListBox.Items.Add($"{position.name}");
                }
            }
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorySelectedIndex= CategoryListBox.SelectedIndex;

            if(currentMenu.parrent!=null && categorySelectedIndex==CategoryListBox.Items.Count-1) 
            {
                SetMenu(currentMenu.parrent);
            }
            else
            {
                SetMenuList(currentMenu.children[categorySelectedIndex] as Menu);
            }
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=BookListBox.SelectedIndex;
            Menu theMenu = currentMenu.children[categorySelectedIndex] as Menu;
            string display = theMenu.children[index].Display();

            if ( display != null)
            {
                MessageBox.Show(theMenu.children[index].Display());
            }
            else
            {
                SetMenu(theMenu);
            }
        }

        void transfer(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Right)
                BookListBox.Focus();       
            else if (e.KeyCode==Keys.Left)          
                CategoryListBox.Focus();
        }
    }
}
