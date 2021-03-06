using UnityEngine;
using LitJson;
using System.Collections;
using System.Collections.Generic;

/*
 *		Author: 	Craig Lomax
 *		Date: 		07.09.2013
 *		URL:		clomax.me.uk
 *		email:		craig@clomax.me.uk
 *
 */

public class Chromosome
{
	public Color colour;
	public Color limb_colour;
	public Vector3 root_scale;
	public float base_joint_frequency;
	public float base_joint_amplitude;
	public float base_joint_phase;
	public decimal hunger_threshold;

    public int num_branches;
    public int[] num_recurrences;

	public ArrayList branches;

    public void setNumBranches(int n)
    {
        num_branches = n;
        if (num_recurrences == null)
            initNumRecurrences(n);
    }

    void initNumRecurrences(int n)
    {
        num_recurrences = new int[n];
    }

	public int getBranchCount() {
		return branches.Count;
	}

	public ArrayList getLimbs(int index) {
		return (ArrayList) branches[index];
	}

	public Color getColour () {
		return colour;
	}

	public Color getLimbColour () {
		return limb_colour;
	}

	public Vector3 getRootScale () {
		return root_scale;
	}

	public ArrayList getBranches () {
		return branches;
	}

	public void setBranches (ArrayList bs) {
		branches = bs;
	}

	public void setColour (float r, float g, float b) {
		colour = new Color(r,g,b);
	}

	public void setLimbColour (float r, float g, float b) {
		limb_colour = new Color(r,g,b);
	}

	public void setRootScale (Vector3 rs) {
		root_scale = rs;
	}

	public void setBaseFequency (float freq) {
		base_joint_frequency = freq;
	}

	public void setBaseAmplitude (float amp) {
		base_joint_amplitude = amp;
	}

	public void setBasePhase (float phase)
	{
		base_joint_phase = phase;
	}
}
