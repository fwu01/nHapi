using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V26.Segment;
using NHapi.Base.Model;

namespace NHapi.Model.V26.Group
{
///<summary>
///Represents the SQR_S25_SCHEDULE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: SCH (Scheduling Activity Information) </li>
///<li>1: TQ1 (Timing/Quantity) optional repeating</li>
///<li>2: NTE (Notes and Comments) optional repeating</li>
///<li>3: SQR_S25_PATIENT (a Group object) optional </li>
///<li>4: SQR_S25_RESOURCES (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class SQR_S25_SCHEDULE : AbstractGroup {

	///<summary> 
	/// Creates a new SQR_S25_SCHEDULE Group.
	///</summary>
	public SQR_S25_SCHEDULE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SCH), true, false);
	      this.add(typeof(TQ1), false, true);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(SQR_S25_PATIENT), false, false);
	      this.add(typeof(SQR_S25_RESOURCES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating SQR_S25_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns SCH (Scheduling Activity Information) - creates it if necessary
	///</summary>
	public SCH SCH { 
get{
	   SCH ret = null;
	   try {
	      ret = (SCH)this.GetStructure("SCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of TQ1 (Timing/Quantity) - creates it if necessary
	///</summary>
	public TQ1 GetTQ1() {
	   TQ1 ret = null;
	   try {
	      ret = (TQ1)this.GetStructure("TQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of TQ1
	/// * (Timing/Quantity) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public TQ1 GetTQ1(int rep) { 
	   return (TQ1)this.GetStructure("TQ1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TQ1 
	 */ 
	public int TQ1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("TQ1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns SQR_S25_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public SQR_S25_PATIENT PATIENT { 
get{
	   SQR_S25_PATIENT ret = null;
	   try {
	      ret = (SQR_S25_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SQR_S25_RESOURCES (a Group object) - creates it if necessary
	///</summary>
	public SQR_S25_RESOURCES GetRESOURCES() {
	   SQR_S25_RESOURCES ret = null;
	   try {
	      ret = (SQR_S25_RESOURCES)this.GetStructure("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SQR_S25_RESOURCES
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SQR_S25_RESOURCES GetRESOURCES(int rep) { 
	   return (SQR_S25_RESOURCES)this.GetStructure("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SQR_S25_RESOURCES 
	 */ 
	public int RESOURCESRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("RESOURCES").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}