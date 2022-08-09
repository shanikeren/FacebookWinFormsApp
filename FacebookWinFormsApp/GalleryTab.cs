﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class GalleryTab : UserControl
    {
        private string[] m_PicturesUrl;
        int index = 0;

        public GalleryTab(List<string> i_picturesUrl)
        {
            InitializeComponent();
            m_PicturesUrl = i_picturesUrl.ToArray();
            CurrentImage.Load(m_PicturesUrl[index]);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            TabControl parent = this.Parent.Parent as TabControl;
            parent.TabPages.Remove((TabPage)this.Parent);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            index++;
            if (index == m_PicturesUrl.Length)
            {
                index = 0;
            }

            CurrentImage.Load(m_PicturesUrl[index]);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = m_PicturesUrl.Length - 1;
            }

            CurrentImage.Load(m_PicturesUrl[index]);

        }
    }
}