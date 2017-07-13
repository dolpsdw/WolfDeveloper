// ***********************************************************************
// Assembly         : UnitTests
// Author           : ShaDoW
// Created          : 07-03-2017
//
// Last Modified By : ShaDoW
// Last Modified On : 07-04-2017
// ***********************************************************************
// <copyright file="ProjectTest.cs" company="Wolf">
//     Jesús González Gómez
// </copyright>
// <summary>Unit Tests for Project model class</summary>
// ***********************************************************************
namespace UnitTests.ModelsUT
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;

    /// <summary>
    /// Class ProjectTest.
    /// </summary>
    [TestClass]
    public class ProjectTest
    {
        /// <summary>
        /// Test the Identifiers getter.
        /// </summary>
        [TestMethod]
        public void IdGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual(36854, p.Id);
        }

        /// <summary>
        /// Test the Names getter.
        /// </summary>
        [TestMethod]
        public void NameGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual("test", p.Name);
        }

        /// <summary>
        /// Test the Picture getter.
        /// </summary>
        [TestMethod]
        public void ImagenGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual("test/path", p.Imagen);
        }

        /// <summary>
        /// Test the Summary getter.
        /// </summary>
        [TestMethod]
        public void SummaryGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual("description", p.Summary);
        }

        /// <summary>
        /// Test the Priority getter.
        /// </summary>
        [TestMethod]
        public void PriorityGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual(ProjColor.White, p.Priority);
        }

        /// <summary>
        /// Test the number of Timers getter.
        /// </summary>
        [TestMethod]
        public void PomodoresGetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.AreEqual(5648, p.Pomodores);
        }

        /// <summary>
        /// Test the Constructors instance.
        /// </summary>
        [TestMethod]
        public void Constructor()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            Assert.IsNotNull(p);
        }

        /// <summary>
        /// Test the Names setter.
        /// </summary>
        [TestMethod]
        public void NameSetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            p = p.SetName("Juju");
            Assert.AreEqual("Juju", p.Name);
        }

        /// <summary>
        /// Test the Picture setter.
        /// </summary>
        [TestMethod]
        public void ImagenSetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            p = p.SetImagen("Imagen");
            Assert.AreEqual("Imagen", p.Imagen);
        }

        /// <summary>
        /// Test the Summary setter.
        /// </summary>
        [TestMethod]
        public void SummarySetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            p = p.SetSummary("Jujutsu");
            Assert.AreEqual("Jujutsu", p.Summary);
        }

        /// <summary>
        /// Test the Priority setter.
        /// </summary>
        [TestMethod]
        public void PrioritySetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            p = p.SetPriority(ProjColor.Black);
            Assert.AreEqual(ProjColor.Black, p.Priority);
        }

        /// <summary>
        /// Test the number of Timers setter.
        /// </summary>
        [TestMethod]
        public void PomodoresSetter()
        {
            Project p = new Project(36854, "test", "test/path", "description", ProjColor.White, 5648);
            p = p.SetPomodores(42);
            Assert.AreEqual(42, p.Pomodores);
        }
    }
}
