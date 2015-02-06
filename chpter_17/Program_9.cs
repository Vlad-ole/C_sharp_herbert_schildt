using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace chpter_17
{

    // Простой пример применения атрибута.

    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string pri_remark; // базовое поле свойства Remark
        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
        }
        public string Remark
        {
            get
            {
                return pri_remark;
            }
        }
    }

    [RemarkAttribute("В этом классе используется атрибут.")]
    class UseAttrib
    {
        // ...
    }

    class Program_9
    {


        static void Main()
        {

            Type t = typeof(UseAttrib);
            Console.Write("Атрибуты в классе " + t.Name + ": ");

            object[] attribs = t.GetCustomAttributes(false);

            foreach (object o in attribs)
            {
                Console.WriteLine(o);
            }

            Console.Write("Примечание: ");

            // Извлечь атрибут RemarkAttribute.
            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute) Attribute.GetCustomAttribute(t, tRemAtt);

            Console.WriteLine(ra.Remark);

            Console.ReadKey();

        }

    }
}
