using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace Budirty
{
    public partial class Button_BootstrapColors : Button
    {
        public enum Type
        {
            Primary,
            Danger,
            Warning,
            Success,
            Info,
            Light,
            Secondary,
            Dark
        }

        Color primary = Color.FromArgb(0, 123, 255);
        Color danger = Color.FromArgb(220, 53, 69);
        Color warning = Color.FromArgb(255, 193, 7);
        Color success = Color.FromArgb(40, 167, 69);
        Color info = Color.FromArgb(23, 162, 184);
        Color light = Color.FromArgb(248, 249, 250);
        Color secondary = Color.FromArgb(134, 142, 150);
        Color dark = Color.FromArgb(52, 58, 64);

        [Browsable(true), DefaultValue("All"), Description("Select what type of bootstrap button")]
        [ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]
        Type _type;

        public Type Btn_Type
        {
            get { return _type; }
            set { _type = value; typeChanged(); }
        }

        public event Action TypeChanged;

        protected void typeChanged()
        {
            Action handler = TypeChanged;
            DisplayDefault();
            handler?.Invoke();
        }

        public Button_BootstrapColors()
        {
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular);

            DisplayDefault();

            MouseHover += Btn_Primary_GotFocus;
            MouseLeave += Btn_Primary_LostFocus;

            GotFocus += Btn_Primary_GotFocus;
            LostFocus += Btn_Primary_LostFocus;
        }

        private void Btn_Primary_LostFocus(object sender, System.EventArgs e)
        {
            DisplayDefault();
        }

        private void Btn_Primary_GotFocus(object sender, System.EventArgs e)
        {
            DisplayReverse();
        }

        private void DisplayDefault()
        {
            switch (_type)
            {
                case Type.Primary:
                    ForeColor = primary;
                    BackColor = light;
                    break;
                case Type.Danger:
                    ForeColor = danger;
                    BackColor = light;
                    break;
                case Type.Warning:
                    ForeColor = warning;
                    BackColor = light;
                    break;
                case Type.Success:
                    ForeColor = success;
                    BackColor = light;
                    break;
                case Type.Info:
                    ForeColor = info;
                    BackColor = light;
                    break;
                case Type.Light:
                    ForeColor = dark;
                    BackColor = light;
                    break;
                case Type.Secondary:
                    ForeColor = secondary;
                    BackColor = light;
                    break;
                case Type.Dark:
                    ForeColor = light;
                    BackColor = dark;
                    break;
            }
        }

        private void DisplayReverse()
        {
            switch (_type)
            {
                case Type.Primary:
                    ForeColor = light;
                    BackColor = primary;
                    break;
                case Type.Danger:
                    ForeColor = light;
                    BackColor = danger;
                    break;
                case Type.Warning:
                    ForeColor = light;
                    BackColor = warning;
                    break;
                case Type.Success:
                    ForeColor = light;
                    BackColor = success;
                    break;
                case Type.Info:
                    ForeColor = light;
                    BackColor = info;
                    break;
                case Type.Light:
                    ForeColor = light;
                    BackColor = dark;
                    break;
                case Type.Secondary:
                    ForeColor = light;
                    BackColor = secondary;
                    break;
                case Type.Dark:
                    ForeColor = dark;
                    BackColor = light;
                    break;
            }
        }
    }
}
