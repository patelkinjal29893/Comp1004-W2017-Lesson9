using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_W2017_Lesson9
{
    public partial class DataForm : Form
    {
        NamesContext NamesDB = new NamesContext();
        SchoolContext SchoolDB = new SchoolContext();

        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comp1004namesDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.comp1004namesDataSet.Users);

            try
            {
                //Selects all the Users in the Users table from the Names Database
                var UsersList = (from User in NamesDB.Users                                  
                                  select User).ToList();

                UsersGridView.DataSource = UsersList;
                
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);                
            }            
                        
            //Selects all the Course in the Courses table from the School Database
            var CourseList = (from Course in SchoolDB.Courses
                              select Course).ToList();

            foreach (var course in CourseList)
            {
                Debug.WriteLine(course.CourseShortDescription);
            }
        }        

        private void UsersGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = sender as DataGridViewCell;
            
        }
    }
}
