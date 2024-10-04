using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        int[] nums = new int[7] {1,4,6,8,0,9,2};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                lbNum.Items.Add(nums[i]);
                NumAsc();
                lbNumAsc.Items.Add(nums[i]);
                //NumDes();
                //lbNumDes.Items.Add(nums[i]);
            }
        }
        private void NumAsc()
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])  //  >
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
        /*
        private void NumDes()
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] < nums[j + 1])  //  <
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }*/
    }
}
