using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V271.Segment;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V271.Group
{
///<summary>
///Represents the ORU_R01_SPECIMEN Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: SPM (Specimen) </li>
///<li>1: ORU_R01_PATIENT_OBSERVATION (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class ORU_R01_SPECIMEN : AbstractGroup {

	///<summary> 
	/// Creates a new ORU_R01_SPECIMEN Group.
	///</summary>
	public ORU_R01_SPECIMEN(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SPM), true, false);
	      this.add(typeof(ORU_R01_PATIENT_OBSERVATION), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORU_R01_SPECIMEN - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SPM (Specimen) - creates it if necessary
	///</summary>
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.GetStructure("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of ORU_R01_PATIENT_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public ORU_R01_PATIENT_OBSERVATION GetPATIENT_OBSERVATION() {
	   ORU_R01_PATIENT_OBSERVATION ret = null;
	   try {
	      ret = (ORU_R01_PATIENT_OBSERVATION)this.GetStructure("PATIENT_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of ORU_R01_PATIENT_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public ORU_R01_PATIENT_OBSERVATION GetPATIENT_OBSERVATION(int rep) { 
	   return (ORU_R01_PATIENT_OBSERVATION)this.GetStructure("PATIENT_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORU_R01_PATIENT_OBSERVATION 
	 */ 
	public int PATIENT_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PATIENT_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the ORU_R01_PATIENT_OBSERVATION results 
	 */ 
	public IEnumerable<ORU_R01_PATIENT_OBSERVATION> PATIENT_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < PATIENT_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (ORU_R01_PATIENT_OBSERVATION)this.GetStructure("PATIENT_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new ORU_R01_PATIENT_OBSERVATION
	///</summary>
	public ORU_R01_PATIENT_OBSERVATION AddPATIENT_OBSERVATION()
	{
		return this.AddStructure("PATIENT_OBSERVATION") as ORU_R01_PATIENT_OBSERVATION;
	}

	///<summary>
	///Removes the given ORU_R01_PATIENT_OBSERVATION
	///</summary>
	public void RemovePATIENT_OBSERVATION(ORU_R01_PATIENT_OBSERVATION toRemove)
	{
		this.RemoveStructure("PATIENT_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the ORU_R01_PATIENT_OBSERVATION at the given index
	///</summary>
	public void RemovePATIENT_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("PATIENT_OBSERVATION", index);
	}

}
}
