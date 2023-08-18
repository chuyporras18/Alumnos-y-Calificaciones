using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Alumnos_y_Calificaciones.home.common
{
    public class CommonMethods
    {

        public string NormalizeString(string s)
        {
            string normalized = s.Normalize(NormalizationForm.FormD);
            StringBuilder result = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public void ShowError(Control field, string e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(field, e);
        }
    }
}
