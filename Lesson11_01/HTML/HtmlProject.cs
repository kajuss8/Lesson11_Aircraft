using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.HTML
{
    internal class HtmlProject
    {
        public string Ataskaita { get; set; }

        public HtmlProject(string ataskaita)
        {
            Ataskaita = ataskaita;
        }
        public void Generator(string ataskaita)
        {
            File.WriteAllText("htmlReport.html", ataskaita);


            
        }
        

    }
}
