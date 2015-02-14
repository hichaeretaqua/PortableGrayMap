﻿namespace PortableGrayMap
{
    using System.IO;
    using Tanpohp.Annotations.Resharper;

    public interface IPortbaleMapReader<out TMap, out TPixel> where TMap : IPortbleAnymap<TPixel>
    {
        /// <summary>
        /// Reads a image from stream.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        TMap ReadFromStream([NotNull]Stream stream);

        /// <summary>
        /// Read the first image within given file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        TMap ReadFromFile([NotNull]string path);
    }
}