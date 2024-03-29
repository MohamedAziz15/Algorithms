﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InsertionSort
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SortBTN_Click(object sender, EventArgs e)
        {
            //int[] myInts = Array.ConvertAll(metroTextBox1.Text.ToArray, int.Parse);
            //string ss =metroTextBox1.Text;
            //string[] arr1 = new[] { ss };
            //int[] arr = new int[] {int.Parse(ss)};
            //List<int> hh = arr1.ToList<int>;
            //(metroTextBox1.Text).ToArray;
            // int[] arrayInt = Array.ConvertAll(arr1, s => int.Parse(s));

            //int[] arr = new int[Convert.ToInt32(arr1)];
            // int[] arr = metroTextBox1.Text.ToList;
            //int[] sorted = insertionSort((int[])metroTextBox1.Text.ToArray, lenght);
            //try
            //{
            //    Image1.Width = Convert.ToInt32(metroTextBox1.Text);
            //}
            //catch (System.FormatException)
            //{
            //    Image1.Width = 100; // or other default value as appropriate in context.
            //}
            int [] array = { 1 * Convert.ToInt32(metroTextBox1.Text) };
            int length = array.Length;
            int[]sorted = insertionSort(array, length);
            beforeSortedLBL.Text = sorted.ToString();

        }
        List<double> beforeListSotring = new List<double>();
        double[] list;
        private int[] insertionSort(int[] array, int lenght)
        {
           // array = { Convert.ToInt32(insertArrayTB.Text) };

            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var flag = 0;

                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }

            return array;
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                list.Append<double>(double.Parse(metroTextBox1.Text));
                //beforeListSotring.Add(Convert.ToDouble(metroTextBox1.Text));
                beforeSortedLBL.Text = beforeListSotring.ToString();
                beforeSortedLBL.Text = list.ToString();
            }
        }

        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }

        private void mergeBTN_Click(object sender, EventArgs e)
        {
              char[] spearator = { ',', ' ' };
            //String[] strlist = str.Split(spearator);
              string[] sk = metroTextBox1.Text.Split(spearator);
              int[] ar;
              for (int k = 0; k < sk.Length; k++)
              {
                int.Parse(sk[k]);
                beforeSortedLBL.Text = sk.ToString();
              }
              //int[] ss = metroTextBox1.Text.Split(spearator);
              beforeSortedLBL.Text = sk.ToString();
              int[] arr = { 76, 89, 23, 1, 55, 78, 99, 12, 65, 100 };
              int n = 10, i;
              Console.WriteLine("Merge Sort");
              Console.Write("Initial array is: ");
              for (i = 0; i < n; i++)
              {
                  Console.Write(arr[i] + " ");
              }
              mergeSort(arr, 0, n - 1);
              Console.Write("Sorted Array is: ");
              for (i = 0; i < n; i++)
              {
           
                  Console.Write(arr[i] + " ");
                  afterSortedLBL.Text += arr[i].ToString();
                  afterSortedLBL.Text += " "; 
           
              }


        }
    }
}
        
    

