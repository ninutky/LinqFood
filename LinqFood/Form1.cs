using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqFood
{
    public partial class Form1 : Form
    {
        static private List<Food> foods = new List<Food>()
        {
            new Food() { Name = "라멘", Type = "일식", Price = 9000 },
            new Food() { Name = "짬뽕", Type = "중식", Price = 12000 },
            new Food() { Name = "김치찌개", Type = "한식", Price = 9500 },
            new Food() { Name = "탕수육", Type = "중식", Price = 15000 },
            new Food() { Name = "규카츠", Type = "일식", Price = 18000 },

            new Food() { Name = "짜장면", Type = "중식", Price = 8400 },
            new Food() { Name = "비빔밥", Type = "한식", Price = 9200 },
            new Food() { Name = "스시", Type = "일식", Price = 7000 },
            new Food() { Name = "깐풍기", Type = "중식", Price = 10000 },
            new Food() { Name = "김치찌개", Type = "한식", Price = 11500 },

            new Food() { Name = "우동", Type = "일식", Price = 9500 },
            new Food() { Name = "불고기", Type = "한식", Price = 8900 },
            new Food() { Name = "마라탕", Type = "중식", Price = 13500 },
            new Food() { Name = "순두부찌개", Type = "한식", Price = 12500 },
            new Food() { Name = "김밥", Type = "한식", Price = 6000 },

            new Food() { Name = "꿔바로우", Type = "중식", Price = 13000 },
            new Food() { Name = "훠궈", Type = "중식", Price = 14000 },
            new Food() { Name = "마파두부", Type = "중식", Price = 9800 },
            new Food() { Name = "부대찌개", Type = "중식", Price = 8200 },
            new Food() { Name = "오코노미야키", Type = "일식", Price = 7400 },
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foodBindingSource.DataSource = from item in foods
                                           select item;
        }
    }
}
