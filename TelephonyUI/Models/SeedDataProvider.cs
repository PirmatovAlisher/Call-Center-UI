using TelephonyUI.Models.CallCenterEnums;
using TelephonyUI.Models.CallCenterModels;

namespace TelephonyUI.Models
{
	public static class SeedDataProvider
	{
		public static List<Agent> Agents { get; } = new List<Agent>();
		public static List<Customer> Customers { get; } = new List<Customer>();
		public static List<Call> Calls { get; } = new List<Call>();
		public static List<InteractionHistory> Interactions { get; } = new List<InteractionHistory>();
		public static List<CallRecording> CallRecordings { get; } = new List<CallRecording>();

		static SeedDataProvider()
		{
			InitializeAgents();
			InitializeCustomers();
			InitializeCalls();
			InitializeInteractions();
			InitializeCallRecordings();
			LinkRelationships();
		}

		private static void InitializeAgents()
		{
			var agents = new List<Agent>
{
	new Agent
	{
		Id = "agent-1",
		FirstName = "Sarah",
		LastName = "Connor",
		Status = AgentStatus.Available,
		Extension = "1001",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-2",
		FirstName = "John",
		LastName = "Doe",
		Status = AgentStatus.OnCall,
		Extension = "1002",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-3",
		FirstName = "Jane",
		LastName = "Smith",
		Status = AgentStatus.AfterCallWork,
		Extension = "1003",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-4",
		FirstName = "Michael",
		LastName = "Johnson",
		Status = AgentStatus.Break,
		Extension = "1004",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-5",
		FirstName = "Emily",
		LastName = "Davis",
		Status = AgentStatus.Offline,
		Extension = "1005",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-6",
		FirstName = "Robert",
		LastName = "Brown",
		Status = AgentStatus.Available,
		Extension = "1006",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-7",
		FirstName = "Linda",
		LastName = "Wilson",
		Status = AgentStatus.OnCall,
		Extension = "1007",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-8",
		FirstName = "William",
		LastName = "Taylor",
		Status = AgentStatus.AfterCallWork,
		Extension = "1008",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-9",
		FirstName = "Elizabeth",
		LastName = "Anderson",
		Status = AgentStatus.Break,
		Extension = "1009",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-10",
		FirstName = "James",
		LastName = "Thomas",
		Status = AgentStatus.Offline,
		Extension = "1010",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-11",
		FirstName = "Patricia",
		LastName = "Jackson",
		Status = AgentStatus.Available,
		Extension = "1011",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-12",
		FirstName = "Charles",
		LastName = "White",
		Status = AgentStatus.OnCall,
		Extension = "1012",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-13",
		FirstName = "Barbara",
		LastName = "Harris",
		Status = AgentStatus.AfterCallWork,
		Extension = "1013",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-14",
		FirstName = "Christopher",
		LastName = "Martin",
		Status = AgentStatus.Break,
		Extension = "1014",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-15",
		FirstName = "Susan",
		LastName = "Thompson",
		Status = AgentStatus.Offline,
		Extension = "1015",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-16",
		FirstName = "Daniel",
		LastName = "Garcia",
		Status = AgentStatus.Available,
		Extension = "1016",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-17",
		FirstName = "Karen",
		LastName = "Martinez",
		Status = AgentStatus.OnCall,
		Extension = "1017",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-18",
		FirstName = "Matthew",
		LastName = "Robinson",
		Status = AgentStatus.AfterCallWork,
		Extension = "1018",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = true
	},
	new Agent
	{
		Id = "agent-19",
		FirstName = "Lisa",
		LastName = "Clark",
		Status = AgentStatus.Break,
		Extension = "1019",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	},
	new Agent
	{
		Id = "agent-20",
		FirstName = "Mark",
		LastName = "Rodriguez",
		Status = AgentStatus.Offline,
		Extension = "1020",
		Skills = new List<AgentSkill>(),
		Shifts = new List<Shift>(),
		IsActive = false
	}
};

			Agents.AddRange(agents);
		}

		private static void InitializeCustomers()
		{
			var customers = new List<Customer>
{
	new Customer
	{
		Id = 1,
		FirstName = "Alice",
		LastName = "Johnson",
		PhoneNumber = "+15551234567",
		Email = "alice.johnson@example.com",
		AccountNumber = "ACC-001",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 2,
		FirstName = "Bob",
		LastName = "Smith",
		PhoneNumber = "+15551234568",
		Email = "bob.smith@example.com",
		AccountNumber = "ACC-002",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 3,
		FirstName = "Charlie",
		LastName = "Davis",
		PhoneNumber = "+15551234569",
		Email = "charlie.davis@example.com",
		AccountNumber = "ACC-003",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 4,
		FirstName = "Diana",
		LastName = "Miller",
		PhoneNumber = "+15551234570",
		Email = "diana.miller@example.com",
		AccountNumber = "ACC-004",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 5,
		FirstName = "Ethan",
		LastName = "Wilson",
		PhoneNumber = "+15551234571",
		Email = "ethan.wilson@example.com",
		AccountNumber = "ACC-005",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 6,
		FirstName = "Fiona",
		LastName = "Brown",
		PhoneNumber = "+15551234572",
		Email = "fiona.brown@example.com",
		AccountNumber = "ACC-006",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 7,
		FirstName = "George",
		LastName = "Taylor",
		PhoneNumber = "+15551234573",
		Email = "george.taylor@example.com",
		AccountNumber = "ACC-007",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 8,
		FirstName = "Hannah",
		LastName = "Anderson",
		PhoneNumber = "+15551234574",
		Email = "hannah.anderson@example.com",
		AccountNumber = "ACC-008",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 9,
		FirstName = "Ian",
		LastName = "Thomas",
		PhoneNumber = "+15551234575",
		Email = "ian.thomas@example.com",
		AccountNumber = "ACC-009",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 10,
		FirstName = "Jessica",
		LastName = "Jackson",
		PhoneNumber = "+15551234576",
		Email = "jessica.jackson@example.com",
		AccountNumber = "ACC-010",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 11,
		FirstName = "Kevin",
		LastName = "White",
		PhoneNumber = "+15551234577",
		Email = "kevin.white@example.com",
		AccountNumber = "ACC-011",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 12,
		FirstName = "Laura",
		LastName = "Harris",
		PhoneNumber = "+15551234578",
		Email = "laura.harris@example.com",
		AccountNumber = "ACC-012",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 13,
		FirstName = "Michael",
		LastName = "Martin",
		PhoneNumber = "+15551234579",
		Email = "michael.martin@example.com",
		AccountNumber = "ACC-013",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 14,
		FirstName = "Natalie",
		LastName = "Thompson",
		PhoneNumber = "+15551234580",
		Email = "natalie.thompson@example.com",
		AccountNumber = "ACC-014",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 15,
		FirstName = "Oliver",
		LastName = "Garcia",
		PhoneNumber = "+15551234581",
		Email = "oliver.garcia@example.com",
		AccountNumber = "ACC-015",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 16,
		FirstName = "Pamela",
		LastName = "Martinez",
		PhoneNumber = "+15551234582",
		Email = "pamela.martinez@example.com",
		AccountNumber = "ACC-016",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 17,
		FirstName = "Quentin",
		LastName = "Robinson",
		PhoneNumber = "+15551234583",
		Email = "quentin.robinson@example.com",
		AccountNumber = "ACC-017",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 18,
		FirstName = "Rachel",
		LastName = "Clark",
		PhoneNumber = "+15551234584",
		Email = "rachel.clark@example.com",
		AccountNumber = "ACC-018",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 19,
		FirstName = "Samuel",
		LastName = "Rodriguez",
		PhoneNumber = "+15551234585",
		Email = "samuel.rodriguez@example.com",
		AccountNumber = "ACC-019",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 20,
		FirstName = "Tina",
		LastName = "Lewis",
		PhoneNumber = "+15551234586",
		Email = "tina.lewis@example.com",
		AccountNumber = "ACC-020",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 21,
		FirstName = "Uma",
		LastName = "Lee",
		PhoneNumber = "+15551234587",
		Email = "uma.lee@example.com",
		AccountNumber = "ACC-021",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 22,
		FirstName = "Victor",
		LastName = "Walker",
		PhoneNumber = "+15551234588",
		Email = "victor.walker@example.com",
		AccountNumber = "ACC-022",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 23,
		FirstName = "Wendy",
		LastName = "Hall",
		PhoneNumber = "+15551234589",
		Email = "wendy.hall@example.com",
		AccountNumber = "ACC-023",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 24,
		FirstName = "Xavier",
		LastName = "Allen",
		PhoneNumber = "+15551234590",
		Email = "xavier.allen@example.com",
		AccountNumber = "ACC-024",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 25,
		FirstName = "Yvonne",
		LastName = "Young",
		PhoneNumber = "+15551234591",
		Email = "yvonne.young@example.com",
		AccountNumber = "ACC-025",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 26,
		FirstName = "Zachary",
		LastName = "Hernandez",
		PhoneNumber = "+15551234592",
		Email = "zachary.hernandez@example.com",
		AccountNumber = "ACC-026",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 27,
		FirstName = "Amanda",
		LastName = "King",
		PhoneNumber = "+15551234593",
		Email = "amanda.king@example.com",
		AccountNumber = "ACC-027",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 28,
		FirstName = "Brian",
		LastName = "Wright",
		PhoneNumber = "+15551234594",
		Email = "brian.wright@example.com",
		AccountNumber = "ACC-028",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 29,
		FirstName = "Cynthia",
		LastName = "Lopez",
		PhoneNumber = "+15551234595",
		Email = "cynthia.lopez@example.com",
		AccountNumber = "ACC-029",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 30,
		FirstName = "David",
		LastName = "Hill",
		PhoneNumber = "+15551234596",
		Email = "david.hill@example.com",
		AccountNumber = "ACC-030",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 31,
		FirstName = "Ella",
		LastName = "Scott",
		PhoneNumber = "+15551234597",
		Email = "ella.scott@example.com",
		AccountNumber = "ACC-031",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 32,
		FirstName = "Frank",
		LastName = "Green",
		PhoneNumber = "+15551234598",
		Email = "frank.green@example.com",
		AccountNumber = "ACC-032",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 33,
		FirstName = "Grace",
		LastName = "Adams",
		PhoneNumber = "+15551234599",
		Email = "grace.adams@example.com",
		AccountNumber = "ACC-033",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 34,
		FirstName = "Henry",
		LastName = "Baker",
		PhoneNumber = "+15551234600",
		Email = "henry.baker@example.com",
		AccountNumber = "ACC-034",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 35,
		FirstName = "Irene",
		LastName = "Nelson",
		PhoneNumber = "+15551234601",
		Email = "irene.nelson@example.com",
		AccountNumber = "ACC-035",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 36,
		FirstName = "Jack",
		LastName = "Carter",
		PhoneNumber = "+15551234602",
		Email = "jack.carter@example.com",
		AccountNumber = "ACC-036",
		Type = CustomerType.Existing,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 37,
		FirstName = "Karen",
		LastName = "Mitchell",
		PhoneNumber = "+15551234603",
		Email = "karen.mitchell@example.com",
		AccountNumber = "ACC-037",
		Type = CustomerType.New,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 38,
		FirstName = "Liam",
		LastName = "Perez",
		PhoneNumber = "+15551234604",
		Email = "liam.perez@example.com",
		AccountNumber = "ACC-038",
		Type = CustomerType.VIP,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 39,
		FirstName = "Monica",
		LastName = "Roberts",
		PhoneNumber = "+15551234605",
		Email = "monica.roberts@example.com",
		AccountNumber = "ACC-039",
		Type = CustomerType.Prospect,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	},
	new Customer
	{
		Id = 40,
		FirstName = "Nathan",
		LastName = "Turner",
		PhoneNumber = "+15551234606",
		Email = "nathan.turner@example.com",
		AccountNumber = "ACC-040",
		Type = CustomerType.Lead,
		Interactions = new List<InteractionHistory>(),
		Cases = new List<Case>()
	}
};

			Customers.AddRange(customers);
		}

		private static void InitializeCalls()
		{
			var now = DateTime.Now;
			var calls = new List<Call>
{
	new Call
	{
		Id = 1,
		CallSid = "CA1000000001",
		CallerNumber = "+15551234567", // US
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-3),
		EndTime = now.AddDays(-3).AddMinutes(6),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-1",
		CustomerId = 1,
		WaitTime = TimeSpan.FromSeconds(15),
		TalkTime = TimeSpan.FromMinutes(4.5),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-1"
	},
	new Call
	{
		Id = 2,
		CallSid = "CA1000000002",
		CallerNumber = "+442079460123", // UK
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-6),
		EndTime = now.AddDays(-6).AddMinutes(7),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-2",
		CustomerId = 2,
		WaitTime = TimeSpan.FromSeconds(16),
		TalkTime = TimeSpan.FromMinutes(4.6),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 3,
		CallSid = "CA1000000003",
		CallerNumber = "+33123456789", // France
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-9),
		EndTime = now.AddDays(-9).AddMinutes(8),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-3",
		CustomerId = 3,
		WaitTime = TimeSpan.FromSeconds(17),
		TalkTime = TimeSpan.FromMinutes(4.7),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-3"
	},
	new Call
	{
		Id = 4,
		CallSid = "CA1000000004",
		CallerNumber = "+49301234567", // Germany
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-12),
		EndTime = now.AddDays(-12).AddMinutes(9),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-4",
		CustomerId = 4,
		WaitTime = TimeSpan.FromSeconds(18),
		TalkTime = TimeSpan.FromMinutes(4.8),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 5,
		CallSid = "CA1000000005",
		CallerNumber = "+81312345678", // Japan
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-15),
		EndTime = now.AddDays(-15).AddMinutes(10),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-5",
		CustomerId = 5,
		WaitTime = TimeSpan.FromSeconds(19),
		TalkTime = TimeSpan.FromMinutes(4.9),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-5"
	},
	new Call
	{
		Id = 6,
		CallSid = "CA1000000006",
		CallerNumber = "+61123456789", // Australia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-18),
		EndTime = now.AddDays(-18).AddMinutes(11),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-6",
		CustomerId = 6,
		WaitTime = TimeSpan.FromSeconds(20),
		TalkTime = TimeSpan.FromMinutes(5.0),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 7,
		CallSid = "CA1000000007",
		CallerNumber = "+911234567890", // India
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-21),
		EndTime = now.AddDays(-21).AddMinutes(12),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-7",
		CustomerId = 7,
		WaitTime = TimeSpan.FromSeconds(21),
		TalkTime = TimeSpan.FromMinutes(5.1),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-7"
	},
	new Call
	{
		Id = 8,
		CallSid = "CA1000000008",
		CallerNumber = "+8613800138000", // China
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-24),
		EndTime = now.AddDays(-24).AddMinutes(13),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-8",
		CustomerId = 8,
		WaitTime = TimeSpan.FromSeconds(22),
		TalkTime = TimeSpan.FromMinutes(5.2),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 9,
		CallSid = "CA1000000009",
		CallerNumber = "+39123456789", // Italy
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-27),
		EndTime = now.AddDays(-27).AddMinutes(14),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-9",
		CustomerId = 9,
		WaitTime = TimeSpan.FromSeconds(23),
		TalkTime = TimeSpan.FromMinutes(5.3),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-9"
	},
	new Call
	{
		Id = 10,
		CallSid = "CA1000000010",
		CallerNumber = "+74951234567", // Russia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-30),
		EndTime = now.AddDays(-30).AddMinutes(15),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-10",
		CustomerId = 10,
		WaitTime = TimeSpan.FromSeconds(24),
		TalkTime = TimeSpan.FromMinutes(5.4),
		IsRecorded = false,
		RecordingUrl = ""
	},
    // --- Second cycle of 10 (Ids 11-20) ---
    new Call
	{
		Id = 11,
		CallSid = "CA1000000011",
		CallerNumber = "+15551234577", // US
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-33),
		EndTime = now.AddDays(-33).AddMinutes(16),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-11",
		CustomerId = 11,
		WaitTime = TimeSpan.FromSeconds(25),
		TalkTime = TimeSpan.FromMinutes(5.5),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-11"
	},
	new Call
	{
		Id = 12,
		CallSid = "CA1000000012",
		CallerNumber = "+442079460124", // UK
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-36),
		EndTime = now.AddDays(-36).AddMinutes(17),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-12",
		CustomerId = 12,
		WaitTime = TimeSpan.FromSeconds(26),
		TalkTime = TimeSpan.FromMinutes(5.6),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 13,
		CallSid = "CA1000000013",
		CallerNumber = "+33123456780", // France
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-39),
		EndTime = now.AddDays(-39).AddMinutes(18),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-13",
		CustomerId = 13,
		WaitTime = TimeSpan.FromSeconds(27),
		TalkTime = TimeSpan.FromMinutes(5.7),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-13"
	},
	new Call
	{
		Id = 14,
		CallSid = "CA1000000014",
		CallerNumber = "+49301234568", // Germany
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-42),
		EndTime = now.AddDays(-42).AddMinutes(19),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-14",
		CustomerId = 14,
		WaitTime = TimeSpan.FromSeconds(28),
		TalkTime = TimeSpan.FromMinutes(5.8),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 15,
		CallSid = "CA1000000015",
		CallerNumber = "+81312345679", // Japan
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-45),
		EndTime = now.AddDays(-45).AddMinutes(20),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-15",
		CustomerId = 15,
		WaitTime = TimeSpan.FromSeconds(29),
		TalkTime = TimeSpan.FromMinutes(5.9),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-15"
	},
	new Call
	{
		Id = 16,
		CallSid = "CA1000000016",
		CallerNumber = "+61123456790", // Australia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-48),
		EndTime = now.AddDays(-48).AddMinutes(21),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-16",
		CustomerId = 16,
		WaitTime = TimeSpan.FromSeconds(30),
		TalkTime = TimeSpan.FromMinutes(6.0),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 17,
		CallSid = "CA1000000017",
		CallerNumber = "+911234567891", // India
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-51),
		EndTime = now.AddDays(-51).AddMinutes(22),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-17",
		CustomerId = 17,
		WaitTime = TimeSpan.FromSeconds(31),
		TalkTime = TimeSpan.FromMinutes(6.1),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-17"
	},
	new Call
	{
		Id = 18,
		CallSid = "CA1000000018",
		CallerNumber = "+8613800138001", // China
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-54),
		EndTime = now.AddDays(-54).AddMinutes(23),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-18",
		CustomerId = 18,
		WaitTime = TimeSpan.FromSeconds(32),
		TalkTime = TimeSpan.FromMinutes(6.2),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 19,
		CallSid = "CA1000000019",
		CallerNumber = "+39123456790", // Italy
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-57),
		EndTime = now.AddDays(-57).AddMinutes(24),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-19",
		CustomerId = 19,
		WaitTime = TimeSpan.FromSeconds(33),
		TalkTime = TimeSpan.FromMinutes(6.3),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-19"
	},
	new Call
	{
		Id = 20,
		CallSid = "CA1000000020",
		CallerNumber = "+74951234568", // Russia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-60),
		EndTime = now.AddDays(-60).AddMinutes(25),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-20",
		CustomerId = 20,
		WaitTime = TimeSpan.FromSeconds(34),
		TalkTime = TimeSpan.FromMinutes(6.4),
		IsRecorded = false,
		RecordingUrl = ""
	},
    // --- Third cycle (Ids 21-30) ---
    new Call
	{
		Id = 21,
		CallSid = "CA1000000021",
		CallerNumber = "+15551234578", // US
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-63),
		EndTime = now.AddDays(-63).AddMinutes(26),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-1",
		CustomerId = 21,
		WaitTime = TimeSpan.FromSeconds(35),
		TalkTime = TimeSpan.FromMinutes(6.5),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-21"
	},
	new Call
	{
		Id = 22,
		CallSid = "CA1000000022",
		CallerNumber = "+442079460125", // UK
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-66),
		EndTime = now.AddDays(-66).AddMinutes(27),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-2",
		CustomerId = 22,
		WaitTime = TimeSpan.FromSeconds(36),
		TalkTime = TimeSpan.FromMinutes(6.6),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 23,
		CallSid = "CA1000000023",
		CallerNumber = "+33123456781", // France
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-69),
		EndTime = now.AddDays(-69).AddMinutes(28),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-3",
		CustomerId = 23,
		WaitTime = TimeSpan.FromSeconds(37),
		TalkTime = TimeSpan.FromMinutes(6.7),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-23"
	},
	new Call
	{
		Id = 24,
		CallSid = "CA1000000024",
		CallerNumber = "+49301234569", // Germany
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-72),
		EndTime = now.AddDays(-72).AddMinutes(29),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-4",
		CustomerId = 24,
		WaitTime = TimeSpan.FromSeconds(38),
		TalkTime = TimeSpan.FromMinutes(6.8),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 25,
		CallSid = "CA1000000025",
		CallerNumber = "+81312345680", // Japan
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-75),
		EndTime = now.AddDays(-75).AddMinutes(30),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-5",
		CustomerId = 25,
		WaitTime = TimeSpan.FromSeconds(39),
		TalkTime = TimeSpan.FromMinutes(6.9),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-25"
	},
	new Call
	{
		Id = 26,
		CallSid = "CA1000000026",
		CallerNumber = "+61123456791", // Australia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-78),
		EndTime = now.AddDays(-78).AddMinutes(31),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-6",
		CustomerId = 26,
		WaitTime = TimeSpan.FromSeconds(40),
		TalkTime = TimeSpan.FromMinutes(7.0),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 27,
		CallSid = "CA1000000027",
		CallerNumber = "+911234567892", // India
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-81),
		EndTime = now.AddDays(-81).AddMinutes(32),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-7",
		CustomerId = 27,
		WaitTime = TimeSpan.FromSeconds(41),
		TalkTime = TimeSpan.FromMinutes(7.1),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-27"
	},
	new Call
	{
		Id = 28,
		CallSid = "CA1000000028",
		CallerNumber = "+8613800138002", // China
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-84),
		EndTime = now.AddDays(-84).AddMinutes(33),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-8",
		CustomerId = 28,
		WaitTime = TimeSpan.FromSeconds(42),
		TalkTime = TimeSpan.FromMinutes(7.2),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 29,
		CallSid = "CA1000000029",
		CallerNumber = "+39123456791", // Italy
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-87),
		EndTime = now.AddDays(-87).AddMinutes(34),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-9",
		CustomerId = 29,
		WaitTime = TimeSpan.FromSeconds(43),
		TalkTime = TimeSpan.FromMinutes(7.3),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-29"
	},
	new Call
	{
		Id = 30,
		CallSid = "CA1000000030",
		CallerNumber = "+74951234569", // Russia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-90),
		EndTime = now.AddDays(-90).AddMinutes(35),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-10",
		CustomerId = 30,
		WaitTime = TimeSpan.FromSeconds(44),
		TalkTime = TimeSpan.FromMinutes(7.4),
		IsRecorded = false,
		RecordingUrl = ""
	},
    // --- Fourth cycle (Ids 31-40) ---
    new Call
	{
		Id = 31,
		CallSid = "CA1000000031",
		CallerNumber = "+15551234579", // US
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-93),
		EndTime = now.AddDays(-93).AddMinutes(36),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-11",
		CustomerId = 31,
		WaitTime = TimeSpan.FromSeconds(45),
		TalkTime = TimeSpan.FromMinutes(7.5),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-31"
	},
	new Call
	{
		Id = 32,
		CallSid = "CA1000000032",
		CallerNumber = "+442079460126", // UK
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-96),
		EndTime = now.AddDays(-96).AddMinutes(37),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-12",
		CustomerId = 32,
		WaitTime = TimeSpan.FromSeconds(46),
		TalkTime = TimeSpan.FromMinutes(7.6),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 33,
		CallSid = "CA1000000033",
		CallerNumber = "+33123456782", // France
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-99),
		EndTime = now.AddDays(-99).AddMinutes(38),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-13",
		CustomerId = 33,
		WaitTime = TimeSpan.FromSeconds(47),
		TalkTime = TimeSpan.FromMinutes(7.7),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-33"
	},
	new Call
	{
		Id = 34,
		CallSid = "CA1000000034",
		CallerNumber = "+49301234570", // Germany
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-102),
		EndTime = now.AddDays(-102).AddMinutes(39),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-14",
		CustomerId = 34,
		WaitTime = TimeSpan.FromSeconds(48),
		TalkTime = TimeSpan.FromMinutes(7.8),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 35,
		CallSid = "CA1000000035",
		CallerNumber = "+81312345681", // Japan
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-105),
		EndTime = now.AddDays(-105).AddMinutes(40),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-15",
		CustomerId = 35,
		WaitTime = TimeSpan.FromSeconds(49),
		TalkTime = TimeSpan.FromMinutes(7.9),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-35"
	},
	new Call
	{
		Id = 36,
		CallSid = "CA1000000036",
		CallerNumber = "+61123456792", // Australia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-108),
		EndTime = now.AddDays(-108).AddMinutes(41),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-16",
		CustomerId = 36,
		WaitTime = TimeSpan.FromSeconds(50),
		TalkTime = TimeSpan.FromMinutes(8.0),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 37,
		CallSid = "CA1000000037",
		CallerNumber = "+911234567893", // India
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-111),
		EndTime = now.AddDays(-111).AddMinutes(42),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-17",
		CustomerId = 37,
		WaitTime = TimeSpan.FromSeconds(51),
		TalkTime = TimeSpan.FromMinutes(8.1),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-37"
	},
	new Call
	{
		Id = 38,
		CallSid = "CA1000000038",
		CallerNumber = "+8613800138003", // China
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-114),
		EndTime = now.AddDays(-114).AddMinutes(43),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-18",
		CustomerId = 38,
		WaitTime = TimeSpan.FromSeconds(52),
		TalkTime = TimeSpan.FromMinutes(8.2),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 39,
		CallSid = "CA1000000039",
		CallerNumber = "+39123456792", // Italy
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-117),
		EndTime = now.AddDays(-117).AddMinutes(44),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-19",
		CustomerId = 39,
		WaitTime = TimeSpan.FromSeconds(53),
		TalkTime = TimeSpan.FromMinutes(8.3),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-39"
	},
	new Call
	{
		Id = 40,
		CallSid = "CA1000000040",
		CallerNumber = "+74951234570", // Russia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-120),
		EndTime = now.AddDays(-120).AddMinutes(45),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-20",
		CustomerId = 40,
		WaitTime = TimeSpan.FromSeconds(54),
		TalkTime = TimeSpan.FromMinutes(8.4),
		IsRecorded = false,
		RecordingUrl = ""
	},
    // --- Final cycle (Ids 41-50) ---
    new Call
	{
		Id = 41,
		CallSid = "CA1000000041",
		CallerNumber = "+15551234580", // US
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-123),
		EndTime = now.AddDays(-123).AddMinutes(46),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-1",
		CustomerId = 41,
		WaitTime = TimeSpan.FromSeconds(55),
		TalkTime = TimeSpan.FromMinutes(8.5),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-41"
	},
	new Call
	{
		Id = 42,
		CallSid = "CA1000000042",
		CallerNumber = "+442079460127", // UK
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-126),
		EndTime = now.AddDays(-126).AddMinutes(47),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-2",
		CustomerId = 42,
		WaitTime = TimeSpan.FromSeconds(56),
		TalkTime = TimeSpan.FromMinutes(8.6),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 43,
		CallSid = "CA1000000043",
		CallerNumber = "+33123456783", // France
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-129),
		EndTime = now.AddDays(-129).AddMinutes(48),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-3",
		CustomerId = 43,
		WaitTime = TimeSpan.FromSeconds(57),
		TalkTime = TimeSpan.FromMinutes(8.7),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-43"
	},
	new Call
	{
		Id = 44,
		CallSid = "CA1000000044",
		CallerNumber = "+49301234571", // Germany
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-132),
		EndTime = now.AddDays(-132).AddMinutes(49),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-4",
		CustomerId = 44,
		WaitTime = TimeSpan.FromSeconds(58),
		TalkTime = TimeSpan.FromMinutes(8.8),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 45,
		CallSid = "CA1000000045",
		CallerNumber = "+81312345682", // Japan
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-135),
		EndTime = now.AddDays(-135).AddMinutes(50),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-5",
		CustomerId = 45,
		WaitTime = TimeSpan.FromSeconds(59),
		TalkTime = TimeSpan.FromMinutes(8.9),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-45"
	},
	new Call
	{
		Id = 46,
		CallSid = "CA1000000046",
		CallerNumber = "+61123456793", // Australia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-138),
		EndTime = now.AddDays(-138).AddMinutes(51),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-6",
		CustomerId = 46,
		WaitTime = TimeSpan.FromSeconds(60),
		TalkTime = TimeSpan.FromMinutes(9.0),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 47,
		CallSid = "CA1000000047",
		CallerNumber = "+911234567894", // India
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-141),
		EndTime = now.AddDays(-141).AddMinutes(52),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-7",
		CustomerId = 47,
		WaitTime = TimeSpan.FromSeconds(61),
		TalkTime = TimeSpan.FromMinutes(9.1),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-47"
	},
	new Call
	{
		Id = 48,
		CallSid = "CA1000000048",
		CallerNumber = "+8613800138004", // China
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-144),
		EndTime = now.AddDays(-144).AddMinutes(53),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-8",
		CustomerId = 48,
		WaitTime = TimeSpan.FromSeconds(62),
		TalkTime = TimeSpan.FromMinutes(9.2),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 49,
		CallSid = "CA1000000049",
		CallerNumber = "+39123456793", // Italy
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-147),
		EndTime = now.AddDays(-147).AddMinutes(54),
		CallType = CallType.Inbound,
		Status = CallStatus.Completed,
		AgentId = "agent-9",
		CustomerId = 49,
		WaitTime = TimeSpan.FromSeconds(63),
		TalkTime = TimeSpan.FromMinutes(9.3),
		IsRecorded = true,
		RecordingUrl = "https://recordings.example.com/call-49"
	},
	new Call
	{
		Id = 50,
		CallSid = "CA1000000050",
		CallerNumber = "+74951234571", // Russia
        DestinationNumber = "+15551000",
		StartTime = now.AddDays(-150),
		EndTime = now.AddDays(-150).AddMinutes(55),
		CallType = CallType.Outbound,
		Status = CallStatus.Completed,
		AgentId = "agent-10",
		CustomerId = 50,
		WaitTime = TimeSpan.FromSeconds(64),
		TalkTime = TimeSpan.FromMinutes(9.4),
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 51,
		CallSid = "CA1000000051",
		CallerNumber = "+447911234567", // UK
        DestinationNumber = "+15551001",
		StartTime = now.AddDays(-120),
		EndTime = now.AddDays(-120),
		CallType = CallType.Missed,
		Status = CallStatus.Completed,
		AgentId = "agent-5",
		CustomerId = 12,
		WaitTime = TimeSpan.FromSeconds(45),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 52,
		CallSid = "CA1000000052",
		CallerNumber = "+4915212345678", // Germany
        DestinationNumber = "+15551002",
		StartTime = now.AddDays(-90),
		EndTime = now.AddDays(-90),
		CallType = CallType.Rejected,
		Status = CallStatus.Completed,
		AgentId = "agent-15",
		CustomerId = 30,
		WaitTime = TimeSpan.FromSeconds(20),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 53,
		CallSid = "CA1000000053",
		CallerNumber = "+33612345678", // France
        DestinationNumber = "+15551003",
		StartTime = now.AddDays(-80),
		EndTime = now.AddDays(-80),
		CallType = CallType.Missed,
		Status = CallStatus.Completed,
		AgentId = "agent-2",
		CustomerId = 7,
		WaitTime = TimeSpan.FromSeconds(33),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 54,
		CallSid = "CA1000000054",
		CallerNumber = "+814512345678", // Japan
        DestinationNumber = "+15551004",
		StartTime = now.AddDays(-70),
		EndTime = now.AddDays(-70),
		CallType = CallType.Rejected,
		Status = CallStatus.Completed,
		AgentId = "agent-20",
		CustomerId = 45,
		WaitTime = TimeSpan.FromSeconds(50),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = null
	},
	new Call
	{
		Id = 55,
		CallSid = "CA1000000055",
		CallerNumber = "+5511912345678", // Brazil
        DestinationNumber = "+15551005",
		StartTime = now.AddDays(-60),
		EndTime = now.AddDays(-60),
		CallType = CallType.Missed,
		Status = CallStatus.Completed,
		AgentId = "agent-9",
		CustomerId = 23,
		WaitTime = TimeSpan.FromSeconds(72),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 56,
		CallSid = "CA1000000056",
		CallerNumber = "+919812345678", // India
        DestinationNumber = "+15551006",
		StartTime = now.AddDays(-50),
		EndTime = now.AddDays(-50),
		CallType = CallType.Rejected,
		Status = CallStatus.Completed,
		AgentId = "agent-12",
		CustomerId = 8,
		WaitTime = TimeSpan.FromSeconds(25),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = null
	},
	new Call
	{
		Id = 57,
		CallSid = "CA1000000057",
		CallerNumber = "+821012345678", // South Korea
        DestinationNumber = "+15551007",
		StartTime = now.AddDays(-40),
		EndTime = now.AddDays(-40),
		CallType = CallType.Missed,
		Status = CallStatus.Completed,
		AgentId = "agent-6",
		CustomerId = 18,
		WaitTime = TimeSpan.FromSeconds(38),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 58,
		CallSid = "CA1000000058",
		CallerNumber = "+61234567890", // Australia
        DestinationNumber = "+15551008",
		StartTime = now.AddDays(-30),
		EndTime = now.AddDays(-30),
		CallType = CallType.Rejected,
		Status = CallStatus.Completed,
		AgentId = "agent-3",
		CustomerId = 29,
		WaitTime = TimeSpan.FromSeconds(60),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	},
	new Call
	{
		Id = 59,
		CallSid = "CA1000000059",
		CallerNumber = "+8613123456789", // China
        DestinationNumber = "+15551009",
		StartTime = now.AddDays(-20),
		EndTime = now.AddDays(-20),
		CallType = CallType.Missed,
		Status = CallStatus.Completed,
		AgentId = "agent-14",
		CustomerId = 35,
		WaitTime = TimeSpan.FromSeconds(42),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = null
	},
	new Call
	{
		Id = 60,
		CallSid = "CA1000000060",
		CallerNumber = "+390612345678", // Italy
        DestinationNumber = "+15551010",
		StartTime = now.AddDays(-10),
		EndTime = now.AddDays(-10),
		CallType = CallType.Rejected,
		Status = CallStatus.Completed,
		AgentId = "agent-1",
		CustomerId = 50,
		WaitTime = TimeSpan.FromSeconds(30),
		TalkTime = TimeSpan.Zero,
		IsRecorded = false,
		RecordingUrl = ""
	}
};

			Calls.AddRange(calls);
		}

		private static void InitializeInteractions()
		{
			var interactions = new List<InteractionHistory>
{
	new InteractionHistory {
		Id = 1,
		InteractionDate = DateTime.Now.AddDays(-2),
		Type = InteractionType.Call,
		Summary = "Call inquiry about account balance [Record 1]",
		RelatedCallId = 1,
		AgentId = "agent-1",
		CustomerId = 1
	},
	new InteractionHistory {
		Id = 2,
		InteractionDate = DateTime.Now.AddDays(-3),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding statement details [Record 2]",
		RelatedCallId = null,
		AgentId = "agent-2",
		CustomerId = 2
	},
	new InteractionHistory {
		Id = 3,
		InteractionDate = DateTime.Now.AddDays(-4),
		Type = InteractionType.Chat,
		Summary = "Chat discussion about loan application status [Record 3]",
		RelatedCallId = null,
		AgentId = "agent-3",
		CustomerId = 3
	},
	new InteractionHistory {
		Id = 4,
		InteractionDate = DateTime.Now.AddDays(-5),
		Type = InteractionType.Callback,
		Summary = "Callback request for service update [Record 4]",
		RelatedCallId = null,
		AgentId = "agent-4",
		CustomerId = 4
	},
	new InteractionHistory {
		Id = 5,
		InteractionDate = DateTime.Now.AddDays(-6),
		Type = InteractionType.Call,
		Summary = "Call inquiry about billing discrepancies [Record 5]",
		RelatedCallId = 5,
		AgentId = "agent-5",
		CustomerId = 5
	},
	new InteractionHistory {
		Id = 6,
		InteractionDate = DateTime.Now.AddDays(-7),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding transaction dispute [Record 6]",
		RelatedCallId = null,
		AgentId = "agent-6",
		CustomerId = 6
	},
	new InteractionHistory {
		Id = 7,
		InteractionDate = DateTime.Now.AddDays(-8),
		Type = InteractionType.Chat,
		Summary = "Chat session about technical support for online banking [Record 7]",
		RelatedCallId = null,
		AgentId = "agent-7",
		CustomerId = 7
	},
	new InteractionHistory {
		Id = 8,
		InteractionDate = DateTime.Now.AddDays(-9),
		Type = InteractionType.Callback,
		Summary = "Callback for account verification process [Record 8]",
		RelatedCallId = null,
		AgentId = "agent-8",
		CustomerId = 8
	},
	new InteractionHistory {
		Id = 9,
		InteractionDate = DateTime.Now.AddDays(-10),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding payment issues [Record 9]",
		RelatedCallId = 9,
		AgentId = "agent-9",
		CustomerId = 9
	},
	new InteractionHistory {
		Id = 10,
		InteractionDate = DateTime.Now.AddDays(-11),
		Type = InteractionType.Email,
		Summary = "Email inquiry about product support options [Record 10]",
		RelatedCallId = null,
		AgentId = "agent-10",
		CustomerId = 10
	},
	new InteractionHistory {
		Id = 11,
		InteractionDate = DateTime.Now.AddDays(-12),
		Type = InteractionType.Chat,
		Summary = "Chat session on refund request procedures [Record 11]",
		RelatedCallId = null,
		AgentId = "agent-11",
		CustomerId = 11
	},
	new InteractionHistory {
		Id = 12,
		InteractionDate = DateTime.Now.AddDays(-13),
		Type = InteractionType.Callback,
		Summary = "Callback request regarding service plan upgrade [Record 12]",
		RelatedCallId = null,
		AgentId = "agent-12",
		CustomerId = 12
	},
	new InteractionHistory {
		Id = 13,
		InteractionDate = DateTime.Now.AddDays(-14),
		Type = InteractionType.Call,
		Summary = "Call inquiry about loan interest rates [Record 13]",
		RelatedCallId = 13,
		AgentId = "agent-13",
		CustomerId = 13
	},
	new InteractionHistory {
		Id = 14,
		InteractionDate = DateTime.Now.AddDays(-15),
		Type = InteractionType.Email,
		Summary = "Email inquiry about account security measures [Record 14]",
		RelatedCallId = null,
		AgentId = "agent-14",
		CustomerId = 14
	},
	new InteractionHistory {
		Id = 15,
		InteractionDate = DateTime.Now.AddDays(-16),
		Type = InteractionType.Chat,
		Summary = "Chat discussion about mobile app issues [Record 15]",
		RelatedCallId = null,
		AgentId = "agent-15",
		CustomerId = 15
	},
	new InteractionHistory {
		Id = 16,
		InteractionDate = DateTime.Now.AddDays(-17),
		Type = InteractionType.Callback,
		Summary = "Callback request for billing clarification [Record 16]",
		RelatedCallId = null,
		AgentId = "agent-16",
		CustomerId = 16
	},
	new InteractionHistory {
		Id = 17,
		InteractionDate = DateTime.Now.AddDays(-18),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding credit card activation [Record 17]",
		RelatedCallId = 17,
		AgentId = "agent-17",
		CustomerId = 17
	},
	new InteractionHistory {
		Id = 18,
		InteractionDate = DateTime.Now.AddDays(-19),
		Type = InteractionType.Email,
		Summary = "Email regarding dispute of recent charge [Record 18]",
		RelatedCallId = null,
		AgentId = "agent-18",
		CustomerId = 18
	},
	new InteractionHistory {
		Id = 19,
		InteractionDate = DateTime.Now.AddDays(-20),
		Type = InteractionType.Chat,
		Summary = "Chat session about updating personal details [Record 19]",
		RelatedCallId = null,
		AgentId = "agent-19",
		CustomerId = 19
	},
	new InteractionHistory {
		Id = 20,
		InteractionDate = DateTime.Now.AddDays(-21),
		Type = InteractionType.Callback,
		Summary = "Callback request for product inquiry [Record 20]",
		RelatedCallId = null,
		AgentId = "agent-20",
		CustomerId = 20
	},
	new InteractionHistory {
		Id = 21,
		InteractionDate = DateTime.Now.AddDays(-22),
		Type = InteractionType.Call,
		Summary = "Call inquiry about recent payments [Record 21]",
		RelatedCallId = 21,
		AgentId = "agent-1",
		CustomerId = 21
	},
	new InteractionHistory {
		Id = 22,
		InteractionDate = DateTime.Now.AddDays(-23),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding service outages [Record 22]",
		RelatedCallId = null,
		AgentId = "agent-2",
		CustomerId = 22
	},
	new InteractionHistory {
		Id = 23,
		InteractionDate = DateTime.Now.AddDays(-24),
		Type = InteractionType.Chat,
		Summary = "Chat discussion on new product features [Record 23]",
		RelatedCallId = null,
		AgentId = "agent-3",
		CustomerId = 23
	},
	new InteractionHistory {
		Id = 24,
		InteractionDate = DateTime.Now.AddDays(-25),
		Type = InteractionType.Callback,
		Summary = "Callback request for technical troubleshooting [Record 24]",
		RelatedCallId = null,
		AgentId = "agent-4",
		CustomerId = 24
	},
	new InteractionHistory {
		Id = 25,
		InteractionDate = DateTime.Now.AddDays(-26),
		Type = InteractionType.Call,
		Summary = "Call inquiry about refund process [Record 25]",
		RelatedCallId = 25,
		AgentId = "agent-5",
		CustomerId = 25
	},
	new InteractionHistory {
		Id = 26,
		InteractionDate = DateTime.Now.AddDays(-27),
		Type = InteractionType.Email,
		Summary = "Email inquiry about loan document requirements [Record 26]",
		RelatedCallId = null,
		AgentId = "agent-6",
		CustomerId = 26
	},
	new InteractionHistory {
		Id = 27,
		InteractionDate = DateTime.Now.AddDays(-28),
		Type = InteractionType.Chat,
		Summary = "Chat session about software update issues [Record 27]",
		RelatedCallId = null,
		AgentId = "agent-7",
		CustomerId = 27
	},
	new InteractionHistory {
		Id = 28,
		InteractionDate = DateTime.Now.AddDays(-29),
		Type = InteractionType.Callback,
		Summary = "Callback request for account reactivation [Record 28]",
		RelatedCallId = null,
		AgentId = "agent-8",
		CustomerId = 28
	},
	new InteractionHistory {
		Id = 29,
		InteractionDate = DateTime.Now.AddDays(-30),
		Type = InteractionType.Call,
		Summary = "Call inquiry about investment options [Record 29]",
		RelatedCallId = 29,
		AgentId = "agent-9",
		CustomerId = 29
	},
	new InteractionHistory {
		Id = 30,
		InteractionDate = DateTime.Now.AddDays(-31),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding savings account benefits [Record 30]",
		RelatedCallId = null,
		AgentId = "agent-10",
		CustomerId = 30
	},
	new InteractionHistory {
		Id = 31,
		InteractionDate = DateTime.Now.AddDays(-32),
		Type = InteractionType.Chat,
		Summary = "Chat session on mortgage application details [Record 31]",
		RelatedCallId = null,
		AgentId = "agent-11",
		CustomerId = 31
	},
	new InteractionHistory {
		Id = 32,
		InteractionDate = DateTime.Now.AddDays(-33),
		Type = InteractionType.Callback,
		Summary = "Callback request for statement reprint [Record 32]",
		RelatedCallId = null,
		AgentId = "agent-12",
		CustomerId = 32
	},
	new InteractionHistory {
		Id = 33,
		InteractionDate = DateTime.Now.AddDays(-34),
		Type = InteractionType.Call,
		Summary = "Call inquiry about credit limit increase [Record 33]",
		RelatedCallId = 33,
		AgentId = "agent-13",
		CustomerId = 33
	},
	new InteractionHistory {
		Id = 34,
		InteractionDate = DateTime.Now.AddDays(-35),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding international transfer fees [Record 34]",
		RelatedCallId = null,
		AgentId = "agent-14",
		CustomerId = 34
	},
	new InteractionHistory {
		Id = 35,
		InteractionDate = DateTime.Now.AddDays(-36),
		Type = InteractionType.Chat,
		Summary = "Chat session discussing online security settings [Record 35]",
		RelatedCallId = null,
		AgentId = "agent-15",
		CustomerId = 35
	},
	new InteractionHistory {
		Id = 36,
		InteractionDate = DateTime.Now.AddDays(-37),
		Type = InteractionType.Callback,
		Summary = "Callback request for new service activation [Record 36]",
		RelatedCallId = null,
		AgentId = "agent-16",
		CustomerId = 36
	},
	new InteractionHistory {
		Id = 37,
		InteractionDate = DateTime.Now.AddDays(-38),
		Type = InteractionType.Call,
		Summary = "Call inquiry about mobile payment options [Record 37]",
		RelatedCallId = 37,
		AgentId = "agent-17",
		CustomerId = 37
	},
	new InteractionHistory {
		Id = 38,
		InteractionDate = DateTime.Now.AddDays(-39),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding fee waiver request [Record 38]",
		RelatedCallId = null,
		AgentId = "agent-18",
		CustomerId = 38
	},
	new InteractionHistory {
		Id = 39,
		InteractionDate = DateTime.Now.AddDays(-40),
		Type = InteractionType.Chat,
		Summary = "Chat session about updating billing address [Record 39]",
		RelatedCallId = null,
		AgentId = "agent-19",
		CustomerId = 39
	},
	new InteractionHistory {
		Id = 40,
		InteractionDate = DateTime.Now.AddDays(-41),
		Type = InteractionType.Callback,
		Summary = "Callback request for subscription renewal [Record 40]",
		RelatedCallId = null,
		AgentId = "agent-20",
		CustomerId = 40
	},
	new InteractionHistory {
		Id = 41,
		InteractionDate = DateTime.Now.AddDays(-42),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding online dispute resolution [Record 41]",
		RelatedCallId = 41,
		AgentId = "agent-1",
		CustomerId = 1
	},
	new InteractionHistory {
		Id = 42,
		InteractionDate = DateTime.Now.AddDays(-43),
		Type = InteractionType.Email,
		Summary = "Email inquiry about card activation process [Record 42]",
		RelatedCallId = null,
		AgentId = "agent-2",
		CustomerId = 2
	},
	new InteractionHistory {
		Id = 43,
		InteractionDate = DateTime.Now.AddDays(-44),
		Type = InteractionType.Chat,
		Summary = "Chat session on updating personal preferences [Record 43]",
		RelatedCallId = null,
		AgentId = "agent-3",
		CustomerId = 3
	},
	new InteractionHistory {
		Id = 44,
		InteractionDate = DateTime.Now.AddDays(-45),
		Type = InteractionType.Callback,
		Summary = "Callback request for payment plan consultation [Record 44]",
		RelatedCallId = null,
		AgentId = "agent-4",
		CustomerId = 4
	},
	new InteractionHistory {
		Id = 45,
		InteractionDate = DateTime.Now.AddDays(-46),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding online account recovery [Record 45]",
		RelatedCallId = 45,
		AgentId = "agent-5",
		CustomerId = 5
	},
	new InteractionHistory {
		Id = 46,
		InteractionDate = DateTime.Now.AddDays(-47),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding branch locations [Record 46]",
		RelatedCallId = null,
		AgentId = "agent-6",
		CustomerId = 6
	},
	new InteractionHistory {
		Id = 47,
		InteractionDate = DateTime.Now.AddDays(-48),
		Type = InteractionType.Chat,
		Summary = "Chat session about promotional offers [Record 47]",
		RelatedCallId = null,
		AgentId = "agent-7",
		CustomerId = 7
	},
	new InteractionHistory {
		Id = 48,
		InteractionDate = DateTime.Now.AddDays(-49),
		Type = InteractionType.Callback,
		Summary = "Callback request for customer loyalty program [Record 48]",
		RelatedCallId = null,
		AgentId = "agent-8",
		CustomerId = 8
	},
	new InteractionHistory {
		Id = 49,
		InteractionDate = DateTime.Now.AddDays(-50),
		Type = InteractionType.Call,
		Summary = "Call inquiry about fee structure details [Record 49]",
		RelatedCallId = 49,
		AgentId = "agent-9",
		CustomerId = 9
	},
	new InteractionHistory {
		Id = 50,
		InteractionDate = DateTime.Now.AddDays(-51),
		Type = InteractionType.Email,
		Summary = "Email inquiry regarding new account setup [Record 50]",
		RelatedCallId = null,
		AgentId = "agent-10",
		CustomerId = 10
	},
	new InteractionHistory {
		Id = 51,
		InteractionDate = DateTime.Now.AddDays(-51),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding account setup [Record 51]",
		RelatedCallId = 51,
		AgentId = "agent-5",   // Matches Call with Id 51
        CustomerId = 12        // Matches Call with Id 51
    },
	new InteractionHistory {
		Id = 52,
		InteractionDate = DateTime.Now.AddDays(-50),
		Type = InteractionType.Call,
		Summary = "Call follow-up regarding service query [Record 52]",
		RelatedCallId = 52,
		AgentId = "agent-15",  // Matches Call with Id 52
        CustomerId = 30        // Matches Call with Id 52
    },
	new InteractionHistory {
		Id = 53,
		InteractionDate = DateTime.Now.AddDays(-49),
		Type = InteractionType.Call,
		Summary = "Call inquiry regarding account issues [Record 53]",
		RelatedCallId = 53,
		AgentId = "agent-2",   // Matches Call with Id 53
        CustomerId = 7         // Matches Call with Id 53
    },
	new InteractionHistory {
		Id = 54,
		InteractionDate = DateTime.Now.AddDays(-48),
		Type = InteractionType.Call,
		Summary = "Call for further clarifications [Record 54]",
		RelatedCallId = 54,
		AgentId = "agent-20",  // Matches Call with Id 54
        CustomerId = 45        // Matches Call with Id 54
    },
	new InteractionHistory {
		Id = 55,
		InteractionDate = DateTime.Now.AddDays(-47),
		Type = InteractionType.Call,
		Summary = "Call regarding billing questions [Record 55]",
		RelatedCallId = 55,
		AgentId = "agent-9",   // Matches Call with Id 55
        CustomerId = 23        // Matches Call with Id 55
    },
	new InteractionHistory {
		Id = 56,
		InteractionDate = DateTime.Now.AddDays(-46),
		Type = InteractionType.Call,
		Summary = "Call inquiry about product features [Record 56]",
		RelatedCallId = 56,
		AgentId = "agent-12",  // Matches Call with Id 56
        CustomerId = 8         // Matches Call with Id 56
    },
	new InteractionHistory {
		Id = 57,
		InteractionDate = DateTime.Now.AddDays(-45),
		Type = InteractionType.Call,
		Summary = "Call follow-up on technical support [Record 57]",
		RelatedCallId = 57,
		AgentId = "agent-6",   // Matches Call with Id 57
        CustomerId = 18        // Matches Call with Id 57
    },
	new InteractionHistory {
		Id = 58,
		InteractionDate = DateTime.Now.AddDays(-44),
		Type = InteractionType.Call,
		Summary = "Call inquiry on service upgrade [Record 58]",
		RelatedCallId = 58,
		AgentId = "agent-3",   // Matches Call with Id 58
        CustomerId = 29        // Matches Call with Id 58
    },
	new InteractionHistory {
		Id = 59,
		InteractionDate = DateTime.Now.AddDays(-43),
		Type = InteractionType.Call,
		Summary = "Call follow-up for feedback [Record 59]",
		RelatedCallId = 59,
		AgentId = "agent-14",  // Matches Call with Id 59
        CustomerId = 35        // Matches Call with Id 59
    },
	new InteractionHistory {
		Id = 60,
		InteractionDate = DateTime.Now.AddDays(-42),
		Type = InteractionType.Call,
		Summary = "Call regarding final confirmation [Record 60]",
		RelatedCallId = 60,
		AgentId = "agent-1",   // Matches Call with Id 60
        CustomerId = 50        // Matches Call with Id 60
    }
};

			Interactions.AddRange(interactions);
		}

		private static void InitializeCallRecordings()
		{
			var baseDate = DateTime.Now; // Or set to a fixed date if needed
			var callRecordings = new List<CallRecording>
{
	new CallRecording
	{
		Id = 1,
		CallId = 1, // from a call where IsRecorded is true
        StoragePath = "CallRecordings/audio1.mp3",
		RecordedAt = baseDate.AddDays(-2).AddMinutes(-45),
		Duration = TimeSpan.FromMinutes(4.5),
		Transcription = "AGENT: Thank you for calling XYZ Corp, how can I help you?\n" +
						"CUSTOMER: I'd like to check my account balance.\n" +
						"AGENT: Certainly, let me pull up your account details..."
	},
	new CallRecording
	{
		Id = 2,
		CallId = 3,
		StoragePath = "CallRecordings/audio2.mp3",
		RecordedAt = baseDate.AddDays(-5).AddMinutes(-50),
		Duration = TimeSpan.FromMinutes(5.0),
		Transcription = "AGENT: Welcome to XYZ Corp, what can I do for you today?\n" +
						"CUSTOMER: I need help with a recent transaction.\n" +
						"AGENT: I'll check your transaction history right away..."
	},
	new CallRecording
	{
		Id = 3,
		CallId = 5,
		StoragePath = "CallRecordings/audio3.mp3",
		RecordedAt = baseDate.AddDays(-8).AddMinutes(-55),
		Duration = TimeSpan.FromMinutes(4.8),
		Transcription = "AGENT: Good day, thank you for calling XYZ Corp. How may I assist?\n" +
						"CUSTOMER: I'm inquiring about my loan application status.\n" +
						"AGENT: Please hold while I retrieve your application details..."
	},
	new CallRecording
	{
		Id = 4,
		CallId = 7,
		StoragePath = "CallRecordings/audio4.mp3",
		RecordedAt = baseDate.AddDays(-12).AddMinutes(-40),
		Duration = TimeSpan.FromMinutes(4.2),
		Transcription = "AGENT: Thank you for reaching XYZ Corp, how can I help you?\n" +
						"CUSTOMER: I have a question regarding my credit card bill.\n" +
						"AGENT: Let me pull up your billing information..."
	},
	new CallRecording
	{
		Id = 5,
		CallId = 9,
		StoragePath = "CallRecordings/audio5.mp3",
		RecordedAt = baseDate.AddDays(-15).AddMinutes(-47),
		Duration = TimeSpan.FromMinutes(4.6),
		Transcription = "AGENT: Hello, thank you for calling XYZ Corp. How may I assist?\n" +
						"CUSTOMER: I'd like to update my contact details.\n" +
						"AGENT: I'll update your records immediately, please wait a moment..."
	},
	new CallRecording
	{
		Id = 6,
		CallId = 11,
		StoragePath = "CallRecordings/audio6.mp3",
		RecordedAt = baseDate.AddDays(-20).AddMinutes(-42),
		Duration = TimeSpan.FromMinutes(5.1),
		Transcription = "AGENT: Welcome to XYZ Corp support, what can I do for you?\n" +
						"CUSTOMER: I need assistance with online banking access.\n" +
						"AGENT: Let me help you regain access to your account..."
	},
	new CallRecording
	{
		Id = 7,
		CallId = 13,
		StoragePath = "CallRecordings/audio7.mp3",
		RecordedAt = baseDate.AddDays(-25).AddMinutes(-38),
		Duration = TimeSpan.FromMinutes(4.7),
		Transcription = "AGENT: Thank you for calling XYZ Corp, how may I help today?\n" +
						"CUSTOMER: I'm having trouble logging into my mobile app.\n" +
						"AGENT: I'll guide you through some troubleshooting steps..."
	},
	new CallRecording
	{
		Id = 8,
		CallId = 15,
		StoragePath = "CallRecordings/audio8.mp3",
		RecordedAt = baseDate.AddDays(-30).AddMinutes(-35),
		Duration = TimeSpan.FromMinutes(4.9),
		Transcription = "AGENT: Good afternoon, you’ve reached XYZ Corp. How can I assist?\n" +
						"CUSTOMER: I would like information on your new account offers.\n" +
						"AGENT: Let me share our latest promotions with you..."
	},
	new CallRecording
	{
		Id = 9,
		CallId = 17,
		StoragePath = "CallRecordings/audio9.mp3",
		RecordedAt = baseDate.AddDays(-35).AddMinutes(-33),
		Duration = TimeSpan.FromMinutes(5.2),
		Transcription = "AGENT: Thank you for calling XYZ Corp, how can I help you today?\n" +
						"CUSTOMER: I'm interested in learning about your investment plans.\n" +
						"AGENT: I'll provide the necessary details shortly..."
	},
	new CallRecording
	{
		Id = 10,
		CallId = 19,
		StoragePath = "CallRecordings/audio10.mp3",
		RecordedAt = baseDate.AddDays(-40).AddMinutes(-30),
		Duration = TimeSpan.FromMinutes(4.3),
		Transcription = "AGENT: Hello and welcome to XYZ Corp support, how may I assist?\n" +
						"CUSTOMER: I need help resolving a billing discrepancy.\n" +
						"AGENT: Let me review your account details to address the issue..."
	}
};

			CallRecordings.AddRange(callRecordings);
		}

		private static void LinkRelationships()
		{
			// Link calls to agents and customers
			foreach (var call in Calls)
			{
				var agent = Agents.FirstOrDefault(a => a.Id == call.AgentId);
				var customer = Customers.FirstOrDefault(c => c.Id == call.CustomerId);

				if (agent != null)
				{
					agent.CurrentCallId = call.Id;
					call.Agent = agent;
				}
				if (customer != null)
				{
					customer.LastContactDate = call.EndTime ?? call.StartTime;
					call.Customer = customer;
				}
			}

			// Link interactions to customers and agents
			foreach (var interaction in Interactions)
			{
				var customer = Customers.FirstOrDefault(c => c.Id == interaction.CustomerId);
				var agent = Agents.FirstOrDefault(a => a.Id == interaction.AgentId);

				if (customer != null)
				{
					customer.Interactions.Add(interaction);
					customer.LastContactDate = interaction.InteractionDate;
				}

				if (agent != null)
				{
					// If you have agent interaction history
					// agent.InteractionHistories.Add(interaction);
				}
			}

			// Link recordings to calls
			foreach (var recording in CallRecordings)
			{
				var call = Calls.FirstOrDefault(c => c.Id == recording.CallId);
				if (call != null)
				{
					recording.Call = call;
					call.RecordingUrl = recording.StoragePath; // Update call's recording URL

					// If Call has a CallRecording navigation property
					// call.CallRecording = recording;
				}
			}
		}

		public static void ResetData()
		{
			Agents.Clear();
			Customers.Clear();
			Calls.Clear();
			Interactions.Clear();
			CallRecordings.Clear();

			InitializeAgents();
			InitializeCustomers();
			InitializeCalls();
			InitializeInteractions();
			InitializeCallRecordings();
			LinkRelationships();
		}
	}
}
