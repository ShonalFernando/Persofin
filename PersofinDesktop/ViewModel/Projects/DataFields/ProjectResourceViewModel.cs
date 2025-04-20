using PersofinDesktop.Model.ProjectManagement;
using PersofinDesktop.Model.UIHelperModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersofinDesktop.ViewModel.Projects
{
    internal partial class ProjectResourceViewModel : ViewModelBase
    {
        // For Editing or Adding new
        private string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _url = string.Empty;
        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged();
            }
        }

        private string _resourceType = "Image";
        public string ResourceType
        {
            get => _resourceType;
            set
            {
                _resourceType = value;
                OnPropertyChanged();
            }
        }

        private string? _collectionName;
        public string? CollectionName
        {
            get => _collectionName;
            set
            {
                _collectionName = value;
                OnPropertyChanged();
            }
        }

        private DateTime _addedOn = DateTime.Now;
        public DateTime AddedOn
        {
            get => _addedOn;
            set
            {
                _addedOn = value;
                OnPropertyChanged();
            }
        }

        private string _notes = string.Empty;
        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }

        // For Viewing all and selecting
        private ObservableCollection<ProjectResource> _resources;
        public ObservableCollection<ProjectResource> Resources
        {
            get => _resources;
            set
            {
                _resources = value;
                OnPropertyChanged();
            }
        }

        private ProjectResource _selectedResource;
        public ProjectResource SelectedResource
        {
            get => _selectedResource;
            set
            {
                _selectedResource = value;
                OnPropertyChanged();
            }
        }

        // For Filters
        private DateTime _dateSelected;
        public DateTime DateSelected
        {
            get => _dateSelected;
            set
            {
                _dateSelected = value;
                OnPropertyChanged();
            }
        }

        private bool _showALl;
        public bool ShowAll
        {
            get => _showALl;
            set
            {
                _showALl = value;
                OnPropertyChanged();
            }
        }

        // UI Tree Structure
        public ObservableCollection<ResourceNode> TreeNodes { get; set; } = new();
        public ObservableCollection<ProjectResource> FilteredResources { get; set; } = new();

        private ResourceNode _selectedNode;
        public ResourceNode SelectedNode
        {
            get => _selectedNode;
            set
            {
                _selectedNode = value;
                OnPropertyChanged();
                //FilterResourcesByNode();
            }
        }

        // Non Binding Fields can be kept in Business Logic
    }
}
