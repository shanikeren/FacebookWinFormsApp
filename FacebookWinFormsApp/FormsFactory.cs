using FacebookLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{

    public enum eFormType
    {
        Main,
        BasicFaceBookForm,
        HangOutForm,
    }

    public class FormsFactory
    {
        public static Object CreateForm(eFormType i_FormType, InitProfile i_InitProfile)
        {
            object toReturn = null;

            if (i_FormType == eFormType.Main)
            {
                toReturn = new FormMain();
            }
            else if (i_FormType == eFormType.BasicFaceBookForm)
            {
                toReturn = new BasicFacebookForm(i_InitProfile);
            }
            else if (i_FormType == eFormType.HangOutForm)
            {
                toReturn = new HangOutForm(i_InitProfile);
            }

            return toReturn;
        }
    }
    }
}
