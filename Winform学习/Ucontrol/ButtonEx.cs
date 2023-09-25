using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucontrol
{
    public class ButtonEx:Button
    {
        //添加属性
        private string _btnText;
        //添加属性和字段
        public string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                
            }
        }
        private string _labText;
        public string LabText
        {
            get { return _labText; }
            set
            {
                _labText = value;
                
            }
        }
    }
}
