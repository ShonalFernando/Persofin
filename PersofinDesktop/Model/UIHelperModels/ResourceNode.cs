using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.Model.UIHelperModels
{
    public class ResourceNode
    {
        public string Title { get; set; }
        public ObservableCollection<ResourceNode> Children { get; set; } = new();
    }
}
