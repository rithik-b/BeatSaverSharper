﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BeatMapsSharp.Models
{
    /// <summary>
    /// A BeatMaps beatmap.
    /// </summary>
    public class Beatmap : IEquatable<Beatmap>
    {
        /// <summary>
        /// Was this map made by an auto-mapper?
        /// </summary>
        public bool Automapper { get; set; }

        /// <summary>
        /// The person who curated this map.
        /// </summary>
        public string? Curator { get; set; }

        /// <summary>
        /// The description of the map.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// The ID of the map.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The metadata for this map.
        /// </summary>
        public BeatmapMetadata Metadata { get; set; } = null!;

        /// <summary>
        /// The name (or title) of the map.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Is this map qualified on ScoreSaber?
        /// </summary>
        public bool Qualified { get; set; }

        /// <summary>
        /// Is this map ranked on ScoreSaber?
        /// </summary>
        public bool Ranked { get; set; }

        /// <summary>
        /// The stats for this map.
        /// </summary>
        public BeatmapStats Stats { get; set; } = null!;

        /// <summary>
        /// The time at which this map was uploaded.
        /// </summary>
        public DateTime Uploaded { get; set; }

        /// <summary>
        /// The uploader of this map.
        /// </summary>
        public User User { get; set; } = null!;

        [JsonProperty("versions")]
        private List<BeatmapVersion> BeatmapVersions { get; set; } = null!;

        /// <summary>
        /// The versions of this map.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<BeatmapVersion> Versions => BeatmapVersions.AsReadOnly();


        // Equality Methods

        public bool Equals(Beatmap? other) => ID == other?.ID;
        public override int GetHashCode() => ID.GetHashCode();
        public override bool Equals(object? obj) => Equals(obj as Beatmap);
        public static bool operator ==(Beatmap left, Beatmap right) => Equals(left, right);
        public static bool operator !=(Beatmap left, Beatmap right) => Equals(left, right);

    }
}