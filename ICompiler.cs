﻿namespace MaiLib
{
    /// <summary>
    /// Provide interface for Compilers
    /// </summary>
    public interface ICompiler
    {
        /// <summary>
        /// Intake information to compile data.
        /// </summary>
        /// <param name="information">TakeInformation to provide</param>
        public void TakeInformation(Dictionary<string, string> information);

        /// <summary>
        /// Compose given chart to specific format.
        /// </summary>
        /// <returns>Corresponding chart</returns>
        public string Compose();

        /// <summary>
        /// Check if the chart given is valid to print.
        /// </summary>
        /// <returns>True if valid, false otherwise</returns>
        public bool CheckValidity();
    }
}

