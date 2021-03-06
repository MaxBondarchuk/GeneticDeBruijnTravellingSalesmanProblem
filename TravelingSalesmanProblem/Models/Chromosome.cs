﻿using System;
using System.Collections.Generic;
using System.Text;
using GeneticAlgorithm.Models;

namespace TravelingSalesmanProblem.Models
{
	public class Chromosome : IChromosome
	{
		#region IChromosome

		public double FitnessValue { get; set; }

		public void EnsureBoundaries()
		{
		}

		#endregion

		public List<int> Vertices { get; set; } = new List<int>();

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append($"Fitness = {Convert.ToInt32(FitnessValue)}:");
			foreach (int d in Vertices)
			{
				sb.Append($"{d,3}");
			}

			return sb.ToString();
		}
	}
}