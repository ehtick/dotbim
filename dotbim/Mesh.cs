﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace dotbim
{
    /// <summary>
    /// Represents a mesh object in three-dimensional space.
    /// </summary>
    public class Mesh
    {
        private int _meshId;

        /// <summary>
        /// The identifier for the mesh.
        /// </summary>
        /// <remarks>
        /// The value of MeshId should be greater than or equal to 0.
        /// </remarks>
        [JsonPropertyName("mesh_id")]
        public int MeshId
        {
            get => _meshId;
            set
            {
                if (value >= 0)
                {
                    _meshId = value;
                }
                else
                {
                    throw new ArgumentException("MeshId should be >= 0");
                }
            }
        }

        /// <summary>
        /// The list of coordinates for the mesh vertices.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public List<double> Coordinates { get; set; }

        /// <summary>
        /// The list of indices for the mesh triangles.
        /// </summary>
        [JsonPropertyName("indices")]
        public List<int> Indices { get; set; }
    }
}