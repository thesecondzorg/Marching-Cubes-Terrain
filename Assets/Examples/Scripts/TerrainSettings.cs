using System;
using UnityEngine;

namespace MarchingCubes.Examples
{
    [System.Serializable]
    public struct TerrainSettings : IEquatable<TerrainSettings>
    {
        [SerializeField] private float noiseFrequency;
        [SerializeField] private int noiseOctaveCount;
        [SerializeField] private float amplitude;
        [SerializeField] private float heightOffset;

        public float NoiseFrequency { get => noiseFrequency; set => noiseFrequency = value; }
        public int NoiseOctaveCount { get => noiseOctaveCount; set => noiseOctaveCount = value; }
        public float Amplitude { get => amplitude; set => amplitude = value; }
        public float HeightOffset { get => heightOffset; set => heightOffset = value; }

        public TerrainSettings(float noiseFrequency, int noiseOctaveCount, float amplitude, float heightOffset)
        {
            this.noiseFrequency = noiseFrequency;
            this.noiseOctaveCount = noiseOctaveCount;
            this.amplitude = amplitude;
            this.heightOffset = heightOffset;
        }

        public bool Equals(TerrainSettings other)
        {
            return noiseFrequency == other.noiseFrequency && noiseOctaveCount == other.noiseOctaveCount && amplitude == other.amplitude && heightOffset == other.heightOffset;
        }
    }
}