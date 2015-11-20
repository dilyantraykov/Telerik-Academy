using SourceControlSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace SourceControlSystem.Web.Api.Models.Projects
{
    public class SaveProjectRequestModel
    {
        [MaxLength(ValidationConstants.MaxProjectName)]
        public string Name { get; set; }

        [MaxLength(ValidationConstants.MaxDescriptionName)]
        public string Description { get; set; }

        public bool IsPrivate { get; set; }
    }
}
