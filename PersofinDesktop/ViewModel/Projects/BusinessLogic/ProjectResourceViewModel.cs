using PersofinDesktop.Helper;
using PersofinDesktop.Model.UIHelperModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectResourceViewModel : ViewModelBase
    {
        // Constructor
        public ProjectResourceViewModel()
        {
            LoadTreeNodes();
        }


        // OTHER METHODS
        private void LoadTreeNodes()
        {
            var jsonPath = Path.Combine(DBPathResolver.ResolveDataDirectoryPath(), "nodeStructure.json");
            var json = File.ReadAllText(jsonPath);
            TreeNodes = JsonSerializer.Deserialize<ObservableCollection<ResourceNode>>(json);
        }

        //private void FilterResourcesByNode()
        //{
        //    if (SelectedNode != null)
        //    {
        //        var selectedPath = GetFullPath(SelectedNode);
        //        FilteredResources.Clear();
        //        foreach (var res in AllResources.Where(r => r.CollectionName == selectedPath))
        //        {
        //            FilteredResources.Add(res);
        //        }
        //    }
        //}

        //private string GetFullPath(ResourceNode node)
        //{
        //    List<string> path = new();
        //    var current = node;
        //    while (current != null)
        //    {
        //        path.Insert(0, current.Title);
        //        current = GetParent(current); // You’ll need a way to track parents or flatten the hierarchy
        //    }
        //    return string.Join("/", path);
        //}
    }
}
