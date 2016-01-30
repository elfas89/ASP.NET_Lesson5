using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Less_5
{
    public partial class Default : System.Web.UI.Page
    {
        private IDictionary<int, Control> controlsDictionary;


        protected void Page_Load(object sender, EventArgs e)
        {
            Button helloButton = new Button(); // Новый объект кнопки
            //helloButton.Text = "Say Hello"; // Текст кнопки
            //helloButton.ID = "helloButton"; // Идентификатор для будущего извлечения
            //Panel1.Controls.Add(helloButton); // Добавление кнопки на панель
            //helloButton.Click += HelloButton_Click;
            //PlaceHolder1.Controls.Add(helloButton);


            //Label sex = new Label();
            //sex.Text = "sex";
            //sex.ID = "sex";
            //PlaceHolder1.Controls.Add(sex);

            //RadioButton m = new RadioButton();
            //m.Text = "m";
            //m.ID = "m";
            //m.AutoPostBack = true;
            //PlaceHolder1.Controls.Add(m);

            //RadioButton f = new RadioButton();
            //f.Text = "f";
            //f.ID = "f";
            //f.AutoPostBack = true;
            //PlaceHolder1.Controls.Add(f);
            //PlaceHolder1.Controls.Add(Span("</br>"));

            //Button b = new Button();
            //b.Text = "Выбрать";
            //b.ID = "b";
            //PlaceHolder1.Controls.Add(b);
            //PlaceHolder1.Controls.Add(Span("</br>"));

            //Label res = new Label();
            //res.Text = "";
            //res.ID = "res";
            //PlaceHolder1.Controls.Add(res);


            //controlsDictionary = new SortedDictionary<int, Control>();
            //controlsDictionary.Add(1, sex);
            //controlsDictionary.Add(2, m);
            //controlsDictionary.Add(3, f);
            //controlsDictionary.Add(4, b);
            //controlsDictionary.Add(5, res);



            

            //m.CheckedChanged += m_CheckedChanged;

            //f.CheckedChanged += f_CheckedChanged;

            //b.Click += b_Click;

             BulletedList MyList = new BulletedList();
             MyList.BulletStyle = BulletStyle.Numbered;
             MyList.Items.Add("Яблоко");
             MyList.Items.Add("Груша");
             MyList.Items.Add("Слива");
             PlaceHolder1.Controls.Add(MyList);

            

        }


        //void m_CheckedChanged(object sender, EventArgs e)
        //{
        //    ((RadioButton)PlaceHolder1.Controls[2]).Checked = false;
        //}

        //void f_CheckedChanged(object sender, EventArgs e)
        //{
        //    ((RadioButton)PlaceHolder1.Controls[1]).Checked = false;
        //}

        //void b_Click(object sender, EventArgs e)
        //{
        //    if (!((RadioButton)controlsDictionary[2]).Checked && !((RadioButton)controlsDictionary[3]).Checked)
        //    {
        //        ((Label)controlsDictionary[5]).Text = "пол не выбран";
        //    }

        //    if (((RadioButton)controlsDictionary[2]).Checked && !((RadioButton)controlsDictionary[3]).Checked)
        //    {
        //        ((Label)controlsDictionary[5]).Text = "пол - МЭ";
        //    }

        //    if (!((RadioButton)controlsDictionary[2]).Checked && ((RadioButton)controlsDictionary[3]).Checked)
        //    {
        //        ((Label)controlsDictionary[5]).Text = "пол - ЖО";
        //    }

        //}



        //protected void HelloButton_Click(object sender, EventArgs e)
        //{
        //    Label helloLabel = new Label();
        //    helloLabel.Text = "Hello";
        //    PlaceHolder1.Controls.Add(helloLabel);
        //} 
       

        protected HtmlGenericControl Span(string innerHTML)
        {
            HtmlGenericControl span = new HtmlGenericControl("span");
            span.InnerHtml = innerHTML;
            return span;
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }


    }
}