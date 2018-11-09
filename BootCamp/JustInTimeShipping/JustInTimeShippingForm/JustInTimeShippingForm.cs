using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JustInTimeShippingCore;
using SAM;

namespace JustInTimeShippingForm
{
    public partial class JustInTimeShippingForm : Form
    {
        ShippingDetailInfo detail;
        double weight = 0;

        JustInTimeShippingFacade controller = JustInTimeShippingFacade.GetInstance();

        public JustInTimeShippingForm()
        {
            InitializeComponent();
        }



        private void btnProcess_Click(object sender, EventArgs e)
        {

            detail = new ShippingDetailInfo();

            detail.OriginAddress = new AddressInfo(txtSender.Text.Trim(),
                txtSenderStreet.Text.Trim(),
                txtSenderCity.Text.Trim(),
                cbSenderStates.SelectedItem.ToString(),
                txtSenderPostal.Text.Trim());
            detail.DestinationAddress = new AddressInfo(txtReceipient.Text.Trim(),
                txtReceipientStreet.Text.Trim(),
                txtReceipientCity.Text.Trim(),
                cbReceipientStates.SelectedItem.ToString(),
                txtReceipientPostal.Text.Trim());

            detail.IsInsured = chkInsurance.Checked;

            // Capture the PackageInfo
            detail.PackageInfo = GetPackageInfo();

           
            // Populate package information
            detail.PackageInfo.Weight = weight;

            // Capture Delivery Type
            detail.DeliveryMethod = GetDeliveryMethod();


            IResult processStatus = controller.Execute(detail);

            if (processStatus.IsSuccess)
            {   
                //display all info in message box , message returned as object of IResult with property message
                MessageBox.Show(processStatus.Message, "Click OK to Accept or Cancel to decline", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show(processStatus.Message, "Fail");
            }
           
                    
        }

        private PackageInfo GetPackageInfo()
        {
            if (cbPackageType.SelectedItem.ToString().CompareTo("Box") == 0)
            {
                return PackageInfoFactory.GetBoxPackageInstance(
                            Convert.ToInt32(numHeight.Value.ToString()),
                            Convert.ToInt32(numWidth.Value.ToString()),
                            Convert.ToInt32(numDepth.Value.ToString()));

            }
            else
            {
                return PackageInfoFactory.GetLetterPackageInstance(cbLetterType.SelectedItem.ToString());
            }
        }

        // Helper method to get Delivery Method
        private DeliveryMethodEnum GetDeliveryMethod()
        {
            if (cbDeliveryType.SelectedItem.ToString().CompareTo("Air") == 0)
            {
                return DeliveryMethodEnum.Air;
            }
            if (cbDeliveryType.SelectedItem.ToString().CompareTo("Ground") == 0)
            {
                return DeliveryMethodEnum.Ground;
            }
            if (cbDeliveryType.SelectedItem.ToString().CompareTo("Rail") == 0)
            {
                return DeliveryMethodEnum.Rail;
            }
            throw new InvalidOperationException("Expect Air, Ground or Rail only.");
        }





        private void cbPackageType_SelectedIndexChanged(object sender, EventArgs e)
        {

            ControlVisibilityBoxLetter();
        }

        private void ControlVisibilityBoxLetter()
        {

            if (cbPackageType.SelectedItem.ToString() != null && cbPackageType.SelectedItem.ToString().CompareTo("Box") == 0)
            {
                grDimension.Visible = true;
                grLetterType.Visible = false;
                chkInsurance.Visible = true;

            }
            else
            {
                grLetterType.Visible = true;
                grDimension.Visible = false;
                chkInsurance.Visible = false;
            }
        }

      

        private void JustInTimeShippingForm_Load(object sender, EventArgs e)
        {
            ControlVisibilityBoxLetter();
        }

        private void btnGetWeigh_Click(object sender, EventArgs e)
        {
            PackageInfo packageInfo = new PackageInfo("Plain");
            SamWeightAdapter handler = new SamWeightAdapter();
            this.weight = handler.GetWeight();
            txtWeigh.Text = this.weight.ToString()+" ounces";
         
        }





    }
}
