using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weinrechnerlel
{

    public class MasterDetailPage1MenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }

        public MasterDetailPage1MenuItem()
        {
            //this.Id = id;
            //this.Title = title;
            //this.TargetType = targetType;

        }

        public MasterDetailPage1MenuItem(int id, string title, Type type)
        {
            this.Id = id;
            this.Title = title;
            this.TargetType = type;
       
        }
       

      
    }
}