using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DATAFIRSTCRUD
{
    public partial class GRIDCRUD : System.Web.UI.Page
    {
        static int x;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                x = 1;
                bindData();
            }
        }
        private void bindData()
        {
           
            ADO db = new DATAFIRSTCRUD.ADO();
            Repeater1.DataSource = db.PatientLogIns.ToList();
            Repeater1.DataBind();
        }



        protected void Repeater1_ItemCommand1(object source, RepeaterCommandEventArgs e)
        {
            TextBox PatientLogInId = (TextBox)e.Item.FindControl("txtPatientLogInId");
            TextBox PatientINfoId = (TextBox)e.Item.FindControl("txtPatientINfoId");
            TextBox PatientName = (TextBox)e.Item.FindControl("txtPatientName");
            TextBox Password = (TextBox)e.Item.FindControl("txtPassword");



            LinkButton Select = (LinkButton)e.Item.FindControl("btnSelect");
            LinkButton Update = (LinkButton)e.Item.FindControl("btnUpdate");
            LinkButton Delete = (LinkButton)e.Item.FindControl("btnDelete");

            RequiredFieldValidator vPatientINfoId = (RequiredFieldValidator)e.Item.FindControl("rfvPatientINfoId");
            RequiredFieldValidator vPatientName = (RequiredFieldValidator)e.Item.FindControl("rfvPatientName");
            RequiredFieldValidator vPassword = (RequiredFieldValidator)e.Item.FindControl("rfvPassword");



            if (e.CommandName == "Select")
            {
                // PatientLogInId.ReadOnly = false;
                PatientINfoId.ReadOnly = false;
                PatientName.ReadOnly = false;
                Password.ReadOnly = false;



                Select.Visible = false;
                Update.Visible = true;
                Delete.Visible = true;

                // PatientLogInId.BackColor = System.Drawing.Color.Yellow;
                PatientINfoId.BackColor = System.Drawing.Color.Yellow;
                PatientName.BackColor = System.Drawing.Color.Yellow;
                Password.BackColor = System.Drawing.Color.Yellow;

            }
            if (e.CommandName == "Update" || e.CommandName == "Delete")

            {
                int id = Convert.ToInt32(PatientLogInId.Text);
                if (e.CommandName == "Update")

                {
                    using (var db = new ADO())
                    {
                        var Patient = db.PatientLogIns.SingleOrDefault(b => b.PatientLogInId == id);
                        if (Patient != null)
                        {
                            Patient.PatientINfoId = Convert.ToInt32(PatientINfoId.Text);
                            Patient.PatientName = PatientName.Text;
                            Patient.Password = Convert.ToInt32(Password.Text);

                            db.SaveChanges();
                            bindData();
                        }
                    }

                }
                if (e.CommandName=="Delete")
                {
                    using (var db = new ADO())
                    {
                        var Pat = db.PatientLogIns.SingleOrDefault(b => b.PatientLogInId == id);
                        {
                            db.PatientLogIns.Remove(Pat);
                            db.SaveChanges();
                            bindData();
                        }
                    }
                }




                Select.Visible = true;
                Update.Visible = false;
                Delete.Visible = false;

                PatientINfoId.BackColor = System.Drawing.Color.White;
                PatientName.BackColor = System.Drawing.Color.White;
                Password.BackColor = System.Drawing.Color.White;

            }

            if (e.CommandName == "Add" || e.CommandName == "Save")
            {
                TextBox fPatientLogInId = (TextBox)e.Item.FindControl("ftxtPatientLogInId");
                TextBox fPatientINfoId = (TextBox)e.Item.FindControl("ftxtPatientINfoId");
                TextBox fPatientName = (TextBox)e.Item.FindControl("ftxtPatientName");
                TextBox fPassword = (TextBox)e.Item.FindControl("ftxtPassword");


                LinkButton fAdd = (LinkButton)e.Item.FindControl("fbtnAdd");
                LinkButton fSave = (LinkButton)e.Item.FindControl("fbtnSave");

                if (e.CommandName == "Add")
                {
                   
                    fPatientINfoId.Visible = true;
                    fPatientName.Visible = true;
                    fPassword.Visible = true;
                    fAdd.Visible = false;
                    fSave.Visible = true;
                }
                if (e.CommandName == "Save")
                {
                    using (var db = new ADO())
                    {
                        PatientLogIn P = new DATAFIRSTCRUD.PatientLogIn();

                        P.PatientINfoId = Convert.ToInt32(fPatientINfoId.Text);
                        P.PatientName = fPatientName.Text;
                        P.Password = Convert.ToInt32(fPassword.Text);
                        db.PatientLogIns.Add(P);
                        db.SaveChanges();
                        bindData();
                    }


                     
                    fPatientINfoId.Visible = false;
                    fPatientName.Visible = false;
                    fPassword.Visible = false;
                    fAdd.Visible = true;
                    fSave.Visible = false;
                }
            }
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType== ListItemType.Item|| e.Item.ItemType==ListItemType.AlternatingItem)
            {

                LinkButton Select = (LinkButton)e.Item.FindControl("btnSelect");
                LinkButton Update = (LinkButton)e.Item.FindControl("btnUpdate");
                LinkButton Delete = (LinkButton)e.Item.FindControl("btnDelete");

                RequiredFieldValidator vPatientINfoId = (RequiredFieldValidator)e.Item.FindControl("rfvPatientINfoId");
                RequiredFieldValidator vPatientName = (RequiredFieldValidator)e.Item.FindControl("rfvPatientName");
                RequiredFieldValidator vPassword = (RequiredFieldValidator)e.Item.FindControl("rfvPassword");

                Update.CausesValidation = true;
                string groupname = "Update" + x.ToString();

                Update.ValidationGroup = groupname;
                vPatientINfoId.ValidationGroup = groupname;
                vPatientName.ValidationGroup = groupname;
                vPassword.ValidationGroup = groupname;
                x = x + 1;
            }
        }
    }
   
}