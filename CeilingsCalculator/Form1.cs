using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeilingsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterTextInTextBoxes();
        }

        private void CenterTextInTextBoxes()
        {
            // Loop through all controls in the form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) // Check if the control is a TextBox
                {
                    // Check the name of the TextBox and apply the TextAlign property
                    if (ctrl.Name.EndsWith("Box") || ctrl.Name.EndsWith("CBox"))
                    {
                        ((TextBox)ctrl).TextAlign = HorizontalAlignment.Center;
                    }
                }
            }
        }

        private void CopyTextBoxContent(TextBox textBox)
        {
            if (textBox != null)
            {
                Clipboard.SetText(textBox.Text); // Copy content to clipboard
            }
        }

        private void execute_Click(object sender, EventArgs e)
        {
            int value, pot, result;

            if (shBox.Text != null && int.TryParse(shBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                shCBox.Text = result.ToString();
            }

            if (plBox.Text != null && int.TryParse(plBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                plCBox.Text = result.ToString();
            }

            if (stBox.Text != null && int.TryParse(stBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                stCBox.Text = result.ToString();
            }

            if (chBox.Text != null && int.TryParse(chBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                chCBox.Text = result.ToString();
            }

            if (poBox.Text != null && int.TryParse(poBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                poCBox.Text = result.ToString();
            }

            if (hitBox.Text != null && int.TryParse(hitBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                hitCBox.Text = result.ToString();
            }

            if (skBox.Text != null && int.TryParse(skBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                skCBox.Text = result.ToString();
            }

            if (enBox.Text != null && int.TryParse(enBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                enCBox.Text = result.ToString();
            }

            if (peBox.Text != null && int.TryParse(peBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                peCBox.Text = result.ToString();
            }

            if (faBox.Text != null && int.TryParse(faBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                faCBox.Text = result.ToString();
            }

            if (leBox.Text != null && int.TryParse(leBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                leCBox.Text = result.ToString();
            }

            if (strBox.Text != null && int.TryParse(strBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateCeiling(value, pot);
                strCBox.Text = result.ToString();
            }

            if (shCBox.Text != null && int.TryParse(shCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                shBox.Text = result.ToString();
            }

            if (plCBox.Text != null && int.TryParse(plCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                plBox.Text = result.ToString();
            }

            if (stCBox.Text != null && int.TryParse(stCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                stBox.Text = result.ToString();
            }

            if (chCBox.Text != null && int.TryParse(chCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                chBox.Text = result.ToString();
            }

            if (poCBox.Text != null && int.TryParse(poCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                poBox.Text = result.ToString();
            }

            if (hitCBox.Text != null && int.TryParse(hitCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                hitBox.Text = result.ToString();
            }

            if (skCBox.Text != null && int.TryParse(skCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                skBox.Text = result.ToString();
            }

            if (enCBox.Text != null && int.TryParse(enCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                enBox.Text = result.ToString();
            }

            if (peCBox.Text != null && int.TryParse(peCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                peBox.Text = result.ToString();
            }

            if (faCBox.Text != null && int.TryParse(faCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                faBox.Text = result.ToString();
            }

            if (leCBox.Text != null && int.TryParse(leCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                leBox.Text = result.ToString();
            }

            if (strCBox.Text != null && int.TryParse(strCBox.Text, out value) && int.TryParse(potBox.Text, out pot))
            {
                result = CalculateStat(value, pot);
                strBox.Text = result.ToString();
            }
            int off = CalculateOff();
            offBox.Text = off.ToString();

            int def = CalculateDef();
            defBox.Text = def.ToString();

            int oa = CalculateOa();
            oaBox.Text = oa.ToString();
        }

        private int CalculateStat(int ceiling, int pot)
        {
            int stat = (pot*ceiling) / 100;
            return stat;
        }

        private int CalculateCeiling(int stat, int pot)
        {
            int ceiling = (stat * 100) / pot;
            return ceiling;
        }

        private int CalculateOff()
        {
            int shooting;
            int playmaking;
            int stickhandling;
            int off;

            if (shBox.Text != null && int.TryParse(shBox.Text, out shooting) && plBox.Text != null && int.TryParse(plBox.Text, out playmaking) && stBox.Text != null && int.TryParse(stBox.Text, out stickhandling))
            {
                off = (shooting + playmaking + stickhandling) / 3;
                return off;
            }
            else
            {
                return 0;
            }
        }

        private int CalculateDef()
        {
            int checking;
            int positioning;
            int hitting;
            int def;

            if (chBox.Text != null && int.TryParse(chBox.Text, out checking) && poBox.Text != null && int.TryParse(poBox.Text, out positioning) && hitBox.Text != null && int.TryParse(hitBox.Text, out hitting))
            {
                def = (checking + positioning + hitting) / 3;
                return def;
            }
            else
            {
                return 0;
            }
        }

        private int CalculateOa()
        {
            int total = 0;
            int count = 0;
            int value;

            // Loop through the TextBoxes for each attribute, excluding "CBox" and "leBox"
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    // Check if the TextBox name ends with "Box" but not "CBox" or "leBox"
                    if (ctrl.Name.EndsWith("Box") && !ctrl.Name.EndsWith("CBox") && ctrl.Name != "leBox")
                    {
                        if (int.TryParse(ctrl.Text, out value)) // Check if the value is a valid integer
                        {
                            total += value;
                            count++;
                        }
                    }
                }
            }

            // If there are valid values, return the average
            if (count > 0)
            {
                return total / count;
            }
            else
            {
                return 0; // Return 0 if no valid values were found
            }
        }


        private void ClearTextBoxes()
        {
            // Loop through all controls in the form
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) // Check if the control is a TextBox
                {
                    // Check the name of the TextBox and clear it if it matches
                    if (ctrl.Name.EndsWith("Box") || ctrl.Name.EndsWith("CBox"))
                    {
                        ctrl.Text = string.Empty;
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void shCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(shBox); // Copy content of shBox to clipboard
        }

        private void shCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(shCBox); // Copy content of shCBox to clipboard
        }

        private void plCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(plBox); // Copy content of plBox to clipboard
        }

        private void plCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(plCBox); // Copy content of plCBox to clipboard
        }

        private void stCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(stBox); // Copy content of stBox to clipboard
        }

        private void stCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(stCBox); // Copy content of stCBox to clipboard
        }

        private void chCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(chBox); // Copy content of chBox to clipboard
        }

        private void chCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(chCBox); // Copy content of chCBox to clipboard
        }

        private void poCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(poBox); // Copy content of poBox to clipboard
        }

        private void poCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(poCBox); // Copy content of poCBox to clipboard
        }

        private void hitCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(hitBox); // Copy content of hitBox to clipboard
        }

        private void hitCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(hitCBox); // Copy content of hitCBox to clipboard
        }

        private void skCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(skBox); // Copy content of skBox to clipboard
        }

        private void skCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(skCBox); // Copy content of skCBox to clipboard
        }

        private void enCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(enBox); // Copy content of enBox to clipboard
        }

        private void enCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(enCBox); // Copy content of enCBox to clipboard
        }

        private void peCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(peBox); // Copy content of peBox to clipboard
        }

        private void peCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(peCBox); // Copy content of peCBox to clipboard
        }

        private void faCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(faBox); // Copy content of faBox to clipboard
        }

        private void faCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(faCBox); // Copy content of faCBox to clipboard
        }

        private void leCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(leBox); // Copy content of leBox to clipboard
        }

        private void leCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(leCBox); // Copy content of leCBox to clipboard
        }

        private void strCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(strBox); // Copy content of strBox to clipboard
        }

        private void strCCopy_Click(object sender, EventArgs e)
        {
            CopyTextBoxContent(strCBox); // Copy content of strCBox to clipboard
        }
    }
}
