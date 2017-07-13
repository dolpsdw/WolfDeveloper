// ***********************************************************************
// Assembly         : WolfDeveloper
// Author           : ShaDoW
// Created          : 07-11-2017
//
// Last Modified By : ShaDoW
// Last Modified On : 07-11-2017
// ***********************************************************************
// <copyright file="ProjectDataService.cs" company="Wolf">
//     Jesús González Gómez
// </copyright>
// <summary>Isollates the calls to the Data Access Layer so if this one changes, only this file need to be update </summary>
// ***********************************************************************
namespace WolfDeveloper.Services
{
    using System.Collections.Generic;

    using DataAccessLayer;

    using Models;

    /// <summary>
    /// Service Class ProjectDataService.
    /// </summary>
    public class ProjectDataService
    {
        /// <summary>
        /// The repository instance common for all instances of the Service
        /// </summary>
        private static IProjectRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDataService"/> class.
        /// if is the first instance, initialize the repository.
        /// </summary>
        public ProjectDataService()
        {
            if (repository == null)
            {
                repository = new ProjectRepository();
            }
        }

        /// <summary>
        /// Gets the project.
        /// </summary>
        /// <param name="id">The Project Identifier.</param>
        /// <returns>new Project.</returns>
        public Project GetProject(int id)
        {
            return repository.GetProject(id);
        }

        /// <summary>
        /// Gets all projects.
        /// </summary>
        /// <returns>new List&lt;Project&gt;.</returns>
        public List<Project> GetAllProjects()
        {
            return repository.GetAllProjects();
        }

        /// <summary>
        /// Updates the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void UpdateProject(Project project)
        {
            repository.UpdateProject(project);
        }

        /// <summary>
        /// Deletes the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void DeleteProject(Project project)
        {
            repository.DeleteProject(project);
        }

        /// <summary>
        /// Adds the project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void AddProject(Project project)
        {
            repository.AddProject(project);
        }
    }
}