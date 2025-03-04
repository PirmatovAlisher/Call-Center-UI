namespace TelephonyUI.Models.CallCenterModels
{
	public class CallRecording
	{
		public int Id { get; set; }
		public int CallId { get; set; }
		public Call Call { get; set; }
		public string StoragePath { get; set; }
		public DateTime RecordedAt { get; set; }
		public TimeSpan Duration { get; set; }
		public string Transcription { get; set; }
	}
}
