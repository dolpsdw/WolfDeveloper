// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProjectRepository.cs" company="Wolf">
//   Jesús González Gómez
// </copyright>
// <summary>
//   Defines the ProjectRepository class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    /// <summary>
    /// Class ProjectRepository.
    /// for isolate the BBDD system.
    /// </summary>
    /// <seealso cref="DataAccessLayer.IProjectRepository" />
    public class ProjectRepository : IProjectRepository
    {
        /// <summary>
        /// The internal static(shared by all instances of the class) list of projects loaded in memory to act as DB.
        /// </summary>
        private static List<Project> projects;

        /// <summary>
        /// Gets the project from Database
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>new Project.</returns>
        public Project GetProject(int id)
        {
            if (projects == null)
            {
                this.LoadHardcodedProjects();
            }

            // ReSharper disable once AssignNullToNotNullAttribute because I am chekking for Null
            return projects.FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Gets all projects from Database
        /// </summary>
        /// <returns>new List&lt;Project&gt;.</returns>
        public List<Project> GetAllProjects()
        {
            if (projects == null)
            {
                this.LoadHardcodedProjects();
            }

            return projects;
        }

        /// <summary>
        /// Deletes the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void DeleteProject(Project project)
        {
            projects.Remove(project);
        }

        /// <summary>
        /// Updates the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void UpdateProject(Project project)
        {
            projects.Remove(projects.FirstOrDefault(p => p.Id == project.Id));
            projects.Add(project);
        }

        /// <summary>
        /// Adds a new project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        /// <summary>
        /// Loads the hardcoded projects.
        /// </summary>
        private void LoadHardcodedProjects()
        {
            projects = new List<Project> { new Project(1, "Prueba", "imagen", "resumen", ProjColor.Black, 0), new Project(2, "Prueba2", "imagen2", "resumen2", ProjColor.Black, 0) };
        }
    }
}
