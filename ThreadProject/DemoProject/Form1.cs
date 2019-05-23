using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoProject.Models;

namespace DemoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void FillUsers()
        {
            dgvUsers.Rows.Clear();
            using (P210_WeekendProductsEntities db = new P210_WeekendProductsEntities())
            {
                List<User> users = db.Users.ToList();
                foreach (var u in users)
                {
                    dgvUsers.Rows.Add(u.Id,
                                      u.Name,
                                      u.Surname,
                                      u.Email);

                    if (!u.Status)
                    {
                        dgvUsers.Rows[dgvUsers.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;

                    }
                }
            }
        }

        private void DeleteUsers()
        {
            using (P210_WeekendProductsEntities db = new P210_WeekendProductsEntities())
            {
                for (int i = 0; i < dgvUsers.SelectedRows.Count; i++)
                {
                    int userId = (int)dgvUsers.SelectedRows[i].Cells[0].Value;
                    User user = db.Users.FirstOrDefault(u => u.Id == userId);
                    user.Status = false;
                }
                db.SaveChanges();
            }
            FillUsers();
        }

        private void btnFillUsers_Click(object sender, EventArgs e)
        {
            FillUsers();    
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUsers();
        }

        private void dgvUsers_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
        }

        private void tsmActive_Click(object sender, EventArgs e)
        {

        }
    }
}
