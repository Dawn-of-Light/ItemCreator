using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ItemCreator
{
	/// <summary>
	/// Database Class for table ITEMTEMPLATE.
	/// </summary>
	public class Item
	{
		/// <summary>
		/// Variable for storing the database connection string.
		/// </summary>
        private MySqlConnection _Connection;

		/// <summary>
		/// Variable for storing instance of database columnn ItemTemplate_ID of table ITEMTEMPLATE.
		/// </summary>
		private string ItemTemplate_ID = null;
		/// <summary>
		/// Variable for storing instance of database columnn Id_nb of table ITEMTEMPLATE.
		/// </summary>
		private string Id_nb = null;
		/// <summary>
		/// Variable for storing instance of database columnn Name of table ITEMTEMPLATE.
		/// </summary>
		private string Name = null;
		/// <summary>
		/// Variable for storing instance of database columnn Level of table ITEMTEMPLATE.
		/// </summary>
		private string Level = null;
        /// <summary>
        /// Variable for storing instance of database columnn Durability of table ITEMTEMPLATE.
        /// </summary>
        private string Durability = null;
        /// <summary>
		/// Variable for storing instance of database columnn MaxDurability of table ITEMTEMPLATE.
		/// </summary>
		private string MaxDurability = null;
		/// <summary>
		/// Variable for storing instance of database columnn Condition of table ITEMTEMPLATE.
		/// </summary>
		private string Condition = null;
		/// <summary>
		/// Variable for storing instance of database columnn MaxCondition of table ITEMTEMPLATE.
		/// </summary>
		private string MaxCondition = null;
		/// <summary>
		/// Variable for storing instance of database columnn Quality of table ITEMTEMPLATE.
		/// </summary>
		private string Quality = null;
		/// <summary>
		/// Variable for storing instance of database columnn DPS_AF of table ITEMTEMPLATE.
		/// </summary>
		private string DPS_AF = null;
		/// <summary>
		/// Variable for storing instance of database columnn SPD_ABS of table ITEMTEMPLATE.
		/// </summary>
		private string SPD_ABS = null;
		/// <summary>
		/// Variable for storing instance of database columnn Hand of table ITEMTEMPLATE.
		/// </summary>
		private string Hand = null;
		/// <summary>
		/// Variable for storing instance of database columnn Type_Damage of table ITEMTEMPLATE.
		/// </summary>
		private string Type_Damage = null;
		/// <summary>
		/// Variable for storing instance of database columnn Object_Type of table ITEMTEMPLATE.
		/// </summary>
		private string Object_Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Item_Type of table ITEMTEMPLATE.
		/// </summary>
		private string Item_Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Color of table ITEMTEMPLATE.
		/// </summary>
		private string Color = null;
		/// <summary>
		/// Variable for storing instance of database columnn Emblem of table ITEMTEMPLATE.
		/// </summary>
		private string Emblem = null;
		/// <summary>
		/// Variable for storing instance of database columnn Effect of table ITEMTEMPLATE.
		/// </summary>
		private string Effect = null;
		/// <summary>
		/// Variable for storing instance of database columnn Weight of table ITEMTEMPLATE.
		/// </summary>
		private string Weight = null;
		/// <summary>
		/// Variable for storing instance of database columnn Model of table ITEMTEMPLATE.
		/// </summary>
		private string Model = null;
		/// <summary>
		/// Variable for storing instance of database columnn Extension of table ITEMTEMPLATE.
		/// </summary>
		private string Extension = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus1 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus1 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus2 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus2 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus3 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus3 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus4 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus4 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus5 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus5 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus6 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus6 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus7 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus7 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus8 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus8 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus9 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus9 = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus10 of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus10 = null;
		/// <summary>
		/// Variable for storing instance of database columnn ExtraBonus of table ITEMTEMPLATE.
		/// </summary>
		private string ExtraBonus = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus1Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus1Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus2Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus2Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus3Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus3Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus4Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus4Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus5Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus5Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus6Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus6Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus7Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus7Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus8Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus8Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus9Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus9Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn Bonus10Type of table ITEMTEMPLATE.
		/// </summary>
		private string Bonus10Type = null;
		/// <summary>
		/// Variable for storing instance of database columnn ExtraBonusType of table ITEMTEMPLATE.
		/// </summary>
		private string ExtraBonusType = null;
		/// <summary>
		/// Variable for storing instance of database columnn IsPickable of table ITEMTEMPLATE.
		/// </summary>
		private bool IsPickable = false;
		/// <summary>
		/// Variable for storing instance of database columnn IsDropable of table ITEMTEMPLATE.
		/// </summary>
		private bool IsDropable = false;
		/// <summary>
		/// Variable for storing instance of database columnn CanDropAsLoot of table ITEMTEMPLATE.
		/// </summary>
		private bool CanDropAsLoot = false;
		/// <summary>
		/// Variable for storing instance of database columnn IsTradable of table ITEMTEMPLATE.
		/// </summary>
		private bool IsTradable = false;
		/// <summary>
		/// Variable for storing instance of database columnn Platinum of table ITEMTEMPLATE.
		/// </summary>
		private string Platinum = null;
		/// <summary>
		/// Variable for storing instance of database columnn Gold of table ITEMTEMPLATE.
		/// </summary>
		private string Gold = null;
		/// <summary>
		/// Variable for storing instance of database columnn Silver of table ITEMTEMPLATE.
		/// </summary>
		private string Silver = null;
		/// <summary>
		/// Variable for storing instance of database columnn Copper of table ITEMTEMPLATE.
		/// </summary>
		private string Copper = null;
		/// <summary>
		/// Variable for storing instance of database columnn MaxCount of table ITEMTEMPLATE.
		/// </summary>
		private string MaxCount = null;
		/// <summary>
		/// Variable for storing instance of database columnn PackSize of table ITEMTEMPLATE.
		/// </summary>
		private string PackSize = null;
		/// <summary>
		/// Variable for storing instance of database columnn Charges of table ITEMTEMPLATE.
		/// </summary>
		private string Charges = null;
		/// <summary>
		/// Variable for storing instance of database columnn MaxCharges of table ITEMTEMPLATE.
		/// </summary>
		private string MaxCharges = null;
		/// <summary>
		/// Variable for storing instance of database columnn Charges1 of table ITEMTEMPLATE.
		/// </summary>
		private string Charges1 = null;
		/// <summary>
		/// Variable for storing instance of database columnn MaxCharges1 of table ITEMTEMPLATE.
		/// </summary>
		private string MaxCharges1 = null;
		/// <summary>
		/// Variable for storing instance of database columnn SpellID of table ITEMTEMPLATE.
		/// </summary>
		private string SpellID = null;
		/// <summary>
		/// Variable for storing instance of database columnn SpellID1 of table ITEMTEMPLATE.
		/// </summary>
		private string SpellID1 = null;
		/// <summary>
		/// Variable for storing instance of database columnn ProcSpellID of table ITEMTEMPLATE.
		/// </summary>
		private string ProcSpellID = null;
		/// <summary>
		/// Variable for storing instance of database columnn ProcSpellID1 of table ITEMTEMPLATE.
		/// </summary>
		private string ProcSpellID1 = null;
		/// <summary>
		/// Variable for storing instance of database columnn PoisonSpellID of table ITEMTEMPLATE.
		/// </summary>
		private string PoisonSpellID = null;
		/// <summary>
		/// Variable for storing instance of database columnn PoisonMaxCharges of table ITEMTEMPLATE.
		/// </summary>
		private string PoisonMaxCharges = null;
		/// <summary>
		/// Variable for storing instance of database columnn PoisonCharges of table ITEMTEMPLATE.
		/// </summary>
		private string PoisonCharges = null;
		/// <summary>
		/// Variable for storing instance of database columnn Realm of table ITEMTEMPLATE.
		/// </summary>
		private string Realm = null;
        /// <summary>
        /// Variable for storing instance of database columnn AllowedClasses of table ITEMTEMPLATE.
        /// </summary>
        private string AllowedClasses = null;

		/// <summary>
		/// Gets or sets the value of ItemTemplateID.
		/// </summary>
		/// <value>
		/// The value of database columnn ItemTemplate_ID of table ITEMTEMPLATE in the current instance.
		/// </value>
		public string ItemTemplateID
		{
			get {return ItemTemplate_ID;}
			set {ItemTemplate_ID = value;}
		}

		/// <summary>
		/// Gets or sets the value of Idnb.
		/// </summary>
		/// <value>
		/// The value of database columnn Id_nb of table ITEMTEMPLATE in the current instance.
		/// </value>
		public string Idnb
		{
			get {return Id_nb;}
			set {Id_nb = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemName.
		/// </summary>
		/// <value>
		/// The value of database columnn Name of table ITEMTEMPLATE in the current instance.
		/// </value>
		public string itemName
		{
			get {return Name;}
			set {Name = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemLevel.
		/// </summary>
		/// <value>
		/// The value of database columnn Level of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemLevel
		{
			get {return Convert.ToInt32(Level);}
			set {Level = value.ToString();}
		}

        /// <summary>
        /// Gets or sets the value of itemDurability.
        /// </summary>
        /// <value>
        /// The value of database columnn Durability of table ITEMTEMPLATE in the current instance.
        /// </value>
        public int itemDurability
        {
            get { return Convert.ToInt32(Durability); }
            set { Durability = value.ToString(); }
        }
		
        /// <summary>
		/// Gets or sets the value of itemMaxDurability.
		/// </summary>
		/// <value>
		/// The value of database columnn MaxDurability of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemMaxDurability
		{
			get {return Convert.ToInt32(MaxDurability);}
			set {MaxDurability = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemCondition.
		/// </summary>
		/// <value>
		/// The value of database columnn Condition of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemCondition
		{
			get {return Convert.ToInt32(Condition);}
			set {Condition = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemMaxCondition.
		/// </summary>
		/// <value>
		/// The value of database columnn MaxCondition of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemMaxCondition
		{
			get {return Convert.ToInt32(MaxCondition);}
			set {MaxCondition = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemQuality.
		/// </summary>
		/// <value>
		/// The value of database columnn Quality of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemQuality
		{
			get {return Convert.ToInt32(Quality);}
			set {Quality = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemDPS_AF.
		/// </summary>
		/// <value>
		/// The value of database columnn DPS_AF of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemDPS_AF
		{
			get {return Convert.ToInt32(DPS_AF);}
			set {DPS_AF = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemSPD_ABS.
		/// </summary>
		/// <value>
		/// The value of database columnn SPD_ABS of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemSPD_ABS
		{
			get {return Convert.ToInt32(SPD_ABS);}
			set {SPD_ABS = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemHand.
		/// </summary>
		/// <value>
		/// The value of database columnn Hand of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemHand
		{
			get {return Convert.ToInt32(Hand);}
			set {Hand = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemType_Damage.
		/// </summary>
		/// <value>
		/// The value of database columnn Type_Damage of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemType_Damage
		{
			get {return Convert.ToInt32(Type_Damage);}
			set {Type_Damage = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemObject_Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Object_Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemObject_Type
		{
			get {return Convert.ToInt32(Object_Type);}
			set {Object_Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemItem_Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Item_Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemItem_Type
		{
			get {return Convert.ToInt32(Item_Type);}
			set {Item_Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemColor.
		/// </summary>
		/// <value>
		/// The value of database columnn Color of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemColor
		{
			get {return Convert.ToInt32(Color);}
			set {Color = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemEmblem.
		/// </summary>
		/// <value>
		/// The value of database columnn Emblem of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemEmblem
		{
			get {return Convert.ToInt32(Emblem);}
			set {Emblem = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemEffect.
		/// </summary>
		/// <value>
		/// The value of database columnn Effect of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemEffect
		{
			get {return Convert.ToInt32(Effect);}
			set {Effect = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemWeight.
		/// </summary>
		/// <value>
		/// The value of database columnn Weight of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemWeight
		{
			get {return Convert.ToInt32(Weight);}
			set {Weight = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemModel.
		/// </summary>
		/// <value>
		/// The value of database columnn Model of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemModel
		{
			get {return Convert.ToInt32(Model);}
			set {Model = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemExtension.
		/// </summary>
		/// <value>
		/// The value of database columnn Extension of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemExtension
		{
			get {return Convert.ToInt32(Extension);}
			set {Extension = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus
		{
			get {return Convert.ToInt32(Bonus);}
			set {Bonus = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus1.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus1 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus1
		{
			get {return Convert.ToInt32(Bonus1);}
			set {Bonus1 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus2.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus2 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus2
		{
			get {return Convert.ToInt32(Bonus2);}
			set {Bonus2 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus3.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus3 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus3
		{
			get {return Convert.ToInt32(Bonus3);}
			set {Bonus3 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus4.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus4 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus4
		{
			get {return Convert.ToInt32(Bonus4);}
			set {Bonus4 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus5.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus5 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus5
		{
			get {return Convert.ToInt32(Bonus5);}
			set {Bonus5 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus6.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus6 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus6
		{
			get {return Convert.ToInt32(Bonus6);}
			set {Bonus6 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus7.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus7 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus7
		{
			get {return Convert.ToInt32(Bonus7);}
			set {Bonus7 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus8.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus8 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus8
		{
			get {return Convert.ToInt32(Bonus8);}
			set {Bonus8 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus9.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus9 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus9
		{
			get {return Convert.ToInt32(Bonus9);}
			set {Bonus9 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus10.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus10 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus10
		{
			get {return Convert.ToInt32(Bonus10);}
			set {Bonus10 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemExtraBonus.
		/// </summary>
		/// <value>
		/// The value of database columnn ExtraBonus of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemExtraBonus
		{
			get {return Convert.ToInt32(ExtraBonus);}
			set {ExtraBonus = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus1Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus1Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus1Type
		{
			get {return Convert.ToInt32(Bonus1Type);}
			set {Bonus1Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus2Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus2Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus2Type
		{
			get {return Convert.ToInt32(Bonus2Type);}
			set {Bonus2Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus3Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus3Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus3Type
		{
			get {return Convert.ToInt32(Bonus3Type);}
			set {Bonus3Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus4Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus4Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus4Type
		{
			get {return Convert.ToInt32(Bonus4Type);}
			set {Bonus4Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus5Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus5Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus5Type
		{
			get {return Convert.ToInt32(Bonus5Type);}
			set {Bonus5Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus6Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus6Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus6Type
		{
			get {return Convert.ToInt32(Bonus6Type);}
			set {Bonus6Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus7Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus7Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus7Type
		{
			get {return Convert.ToInt32(Bonus7Type);}
			set {Bonus7Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus8Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus8Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus8Type
		{
			get {return Convert.ToInt32(Bonus8Type);}
			set {Bonus8Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus9Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus9Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus9Type
		{
			get {return Convert.ToInt32(Bonus9Type);}
			set {Bonus9Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemBonus10Type.
		/// </summary>
		/// <value>
		/// The value of database columnn Bonus10Type of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemBonus10Type
		{
			get {return Convert.ToInt32(Bonus10Type);}
			set {Bonus10Type = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemExtraBonusType.
		/// </summary>
		/// <value>
		/// The value of database columnn ExtraBonusType of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemExtraBonusType
		{
			get {return Convert.ToInt32(ExtraBonusType);}
			set {ExtraBonusType = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemIsPickable.
		/// </summary>
		/// <value>
		/// The value of database columnn IsPickable of table ITEMTEMPLATE in the current instance.
		/// </value>
		public bool itemIsPickable
		{
			get {return IsPickable;}
			set {IsPickable = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemIsDropable.
		/// </summary>
		/// <value>
		/// The value of database columnn IsDropable of table ITEMTEMPLATE in the current instance.
		/// </value>
		public bool itemIsDropable
		{
			get {return IsDropable;}
			set {IsDropable = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemCanDropAsLoot.
		/// </summary>
		/// <value>
		/// The value of database columnn CanDropAsLoot of table ITEMTEMPLATE in the current instance.
		/// </value>
		public bool itemCanDropAsLoot
		{
			get {return CanDropAsLoot;}
			set {CanDropAsLoot = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemIsTradable.
		/// </summary>
		/// <value>
		/// The value of database columnn IsTradable of table ITEMTEMPLATE in the current instance.
		/// </value>
		public bool itemIsTradable
		{
			get {return IsTradable;}
			set {IsTradable = value;}
		}

		/// <summary>
		/// Gets or sets the value of itemPlatinum.
		/// </summary>
		/// <value>
		/// The value of database columnn Platinum of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemPlatinum
		{
			get {return Convert.ToInt32(Platinum);}
			set {Platinum = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemGold.
		/// </summary>
		/// <value>
		/// The value of database columnn Gold of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemGold
		{
			get {return Convert.ToInt32(Gold);}
			set {Gold = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemSilver.
		/// </summary>
		/// <value>
		/// The value of database columnn Silver of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemSilver
		{
			get {return Convert.ToInt32(Silver);}
			set {Silver = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemCopper.
		/// </summary>
		/// <value>
		/// The value of database columnn Copper of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemCopper
		{
			get {return Convert.ToInt32(Copper);}
			set {Copper = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemMaxCount.
		/// </summary>
		/// <value>
		/// The value of database columnn MaxCount of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemMaxCount
		{
			get {return Convert.ToInt32(MaxCount);}
			set {MaxCount = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemPackSize.
		/// </summary>
		/// <value>
		/// The value of database columnn PackSize of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemPackSize
		{
			get {return Convert.ToInt32(PackSize);}
			set {PackSize = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemCharges.
		/// </summary>
		/// <value>
		/// The value of database columnn Charges of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemCharges
		{
			get {return Convert.ToInt32(Charges);}
			set {Charges = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemMaxCharges.
		/// </summary>
		/// <value>
		/// The value of database columnn MaxCharges of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemMaxCharges
		{
			get {return Convert.ToInt32(MaxCharges);}
			set {MaxCharges = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemCharges1.
		/// </summary>
		/// <value>
		/// The value of database columnn Charges1 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemCharges1
		{
			get {return Convert.ToInt32(Charges1);}
			set {Charges1 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemMaxCharges1.
		/// </summary>
		/// <value>
		/// The value of database columnn MaxCharges1 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemMaxCharges1
		{
			get {return Convert.ToInt32(MaxCharges1);}
			set {MaxCharges1 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemSpellID.
		/// </summary>
		/// <value>
		/// The value of database columnn SpellID of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemSpellID
		{
			get {return Convert.ToInt32(SpellID);}
			set {SpellID = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemSpellID1.
		/// </summary>
		/// <value>
		/// The value of database columnn SpellID1 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemSpellID1
		{
			get {return Convert.ToInt32(SpellID1);}
			set {SpellID1 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemProcSpellID.
		/// </summary>
		/// <value>
		/// The value of database columnn ProcSpellID of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemProcSpellID
		{
			get {return Convert.ToInt32(ProcSpellID);}
			set {ProcSpellID = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemProcSpellID1.
		/// </summary>
		/// <value>
		/// The value of database columnn ProcSpellID1 of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemProcSpellID1
		{
			get {return Convert.ToInt32(ProcSpellID1);}
			set {ProcSpellID1 = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemPoisonSpellID.
		/// </summary>
		/// <value>
		/// The value of database columnn PoisonSpellID of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemPoisonSpellID
		{
			get {return Convert.ToInt32(PoisonSpellID);}
			set {PoisonSpellID = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemPoisonMaxCharges.
		/// </summary>
		/// <value>
		/// The value of database columnn PoisonMaxCharges of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemPoisonMaxCharges
		{
			get {return Convert.ToInt32(PoisonMaxCharges);}
			set {PoisonMaxCharges = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemPoisonCharges.
		/// </summary>
		/// <value>
		/// The value of database columnn PoisonCharges of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemPoisonCharges
		{
			get {return Convert.ToInt32(PoisonCharges);}
			set {PoisonCharges = value.ToString();}
		}

		/// <summary>
		/// Gets or sets the value of itemRealm.
		/// </summary>
		/// <value>
		/// The value of database columnn Realm of table ITEMTEMPLATE in the current instance.
		/// </value>
		public int itemRealm
		{
			get {return Convert.ToInt32(Realm);}
			set {Realm = value.ToString();}
		}

        /// <summary>
		/// Gets or sets the value of itemRealm.
		/// </summary>
		/// <value>
		/// The value of database columnn Realm of table ITEMTEMPLATE in the current instance.
		/// </value>
        public string itemAllowedClasses
		{
            get { return AllowedClasses; }
            set { AllowedClasses = value; }
		}

		/// <summary>
		/// Initializes a new instance of the item class.
		/// </summary>
		/// <param name="ConnectionString">
		/// Database connection string.
		/// </param>
        public Item(MySqlConnection connection)
		{
            _Connection = connection;
		}

		/// <summary>
		/// Initializes a new instance of the item class.
		/// </summary>
		/// <param name="ConnectionString">
		/// Database connection string.
		/// </param>
		/// <param name="ItemTemplateID">
		/// Primary key for database table ITEMTEMPLATE.
		/// </param>
        public Item(string ItemID, MySqlConnection con)
		{
            _Connection = con;
            MySqlCommand cmd = new MySqlCommand("SELECT ItemTemplate_ID,Id_nb,Name,Level,Durability,MaxDurability,`Condition`,MaxCondition,Quality,DPS_AF,SPD_ABS,Hand,Type_Damage,Object_Type,Item_Type,Color,Emblem,Effect,Weight,Model,Extension,Bonus,Bonus1,Bonus2,Bonus3,Bonus4,Bonus5,Bonus6,Bonus7,Bonus8,Bonus9,Bonus10,ExtraBonus,Bonus1Type,Bonus2Type,Bonus3Type,Bonus4Type,Bonus5Type,Bonus6Type,Bonus7Type,Bonus8Type,Bonus9Type,Bonus10Type,ExtraBonusType,IsPickable,IsDropable,CanDropAsLoot,IsTradable,Platinum,Gold,Silver,Copper,MaxCount,PackSize,Charges,MaxCharges,Charges1,MaxCharges1,SpellID,SpellID1,ProcSpellID,ProcSpellID1,PoisonSpellID,PoisonMaxCharges,PoisonCharges,Realm,AllowedClasses FROM itemtemplate WHERE Id_nb = ?Id_nb", con);

            cmd.Parameters.AddWithValue("?Id_nb", ItemID);

			MySqlDataReader dr;

			con.Open();
			dr = cmd.ExecuteReader();

			if(dr.Read())
			{
				ItemTemplate_ID = dr["ItemTemplate_ID"].ToString();
				Id_nb = dr["Id_nb"].ToString();
				Name = dr["Name"].ToString();
				Level = dr["Level"].ToString();
                Durability = dr["Durability"].ToString();
                MaxDurability = dr["MaxDurability"].ToString();
				Condition = dr["Condition"].ToString();
				MaxCondition = dr["MaxCondition"].ToString();
				Quality = dr["Quality"].ToString();
				DPS_AF = dr["DPS_AF"].ToString();
				SPD_ABS = dr["SPD_ABS"].ToString();
				Hand = dr["Hand"].ToString();
				Type_Damage = dr["Type_Damage"].ToString();
				Object_Type = dr["Object_Type"].ToString();
				Item_Type = dr["Item_Type"].ToString();
				Color = dr["Color"].ToString();
				Emblem = dr["Emblem"].ToString();
				Effect = dr["Effect"].ToString();
				Weight = dr["Weight"].ToString();
				Model = dr["Model"].ToString();
				Extension = dr["Extension"].ToString();
				Bonus = dr["Bonus"].ToString();
				Bonus1 = dr["Bonus1"].ToString();
				Bonus2 = dr["Bonus2"].ToString();
				Bonus3 = dr["Bonus3"].ToString();
				Bonus4 = dr["Bonus4"].ToString();
				Bonus5 = dr["Bonus5"].ToString();
				Bonus6 = dr["Bonus6"].ToString();
				Bonus7 = dr["Bonus7"].ToString();
				Bonus8 = dr["Bonus8"].ToString();
				Bonus9 = dr["Bonus9"].ToString();
				Bonus10 = dr["Bonus10"].ToString();
				ExtraBonus = dr["ExtraBonus"].ToString();
				Bonus1Type = dr["Bonus1Type"].ToString();
				Bonus2Type = dr["Bonus2Type"].ToString();
				Bonus3Type = dr["Bonus3Type"].ToString();
				Bonus4Type = dr["Bonus4Type"].ToString();
				Bonus5Type = dr["Bonus5Type"].ToString();
				Bonus6Type = dr["Bonus6Type"].ToString();
				Bonus7Type = dr["Bonus7Type"].ToString();
				Bonus8Type = dr["Bonus8Type"].ToString();
				Bonus9Type = dr["Bonus9Type"].ToString();
				Bonus10Type = dr["Bonus10Type"].ToString();
				ExtraBonusType = dr["ExtraBonusType"].ToString();
				IsPickable = Convert.ToBoolean(dr["IsPickable"]);
				IsDropable = Convert.ToBoolean(dr["IsDropable"]);
				CanDropAsLoot = Convert.ToBoolean(dr["CanDropAsLoot"]);
				IsTradable = Convert.ToBoolean(dr["IsTradable"]);
				Platinum = dr["Platinum"].ToString();
				Gold = dr["Gold"].ToString();
				Silver = dr["Silver"].ToString();
				Copper = dr["Copper"].ToString();
				MaxCount = dr["MaxCount"].ToString();
				PackSize = dr["PackSize"].ToString();
				Charges = dr["Charges"].ToString();
				MaxCharges = dr["MaxCharges"].ToString();
				Charges1 = dr["Charges1"].ToString();
				MaxCharges1 = dr["MaxCharges1"].ToString();
				SpellID = dr["SpellID"].ToString();
				SpellID1 = dr["SpellID1"].ToString();
				ProcSpellID = dr["ProcSpellID"].ToString();
				ProcSpellID1 = dr["ProcSpellID1"].ToString();
				PoisonSpellID = dr["PoisonSpellID"].ToString();
				PoisonMaxCharges = dr["PoisonMaxCharges"].ToString();
				PoisonCharges = dr["PoisonCharges"].ToString();
				Realm = dr["Realm"].ToString();
                AllowedClasses = dr["AllowedClasses"].ToString();
			}

			dr.Close();
			con.Close();
		}

		/// <summary>
		/// Method for inserting row into database table ITEMTEMPLATE.
		/// </summary>
		public void Insert()
		{
			MySqlConnection con = _Connection;
			MySqlCommand cmd = con.CreateCommand();

            string SQL = "INSERT INTO itemtemplate (ItemTemplate_ID,Id_nb,Name,Level,Durability,MaxDurability,`Condition`,MaxCondition,Quality,DPS_AF,SPD_ABS,Hand,Type_Damage,Object_Type,Item_Type,Color,Emblem,Effect,Weight,Model,Extension,Bonus,Bonus1,Bonus2,Bonus3,Bonus4,Bonus5,Bonus6,Bonus7,Bonus8,Bonus9,Bonus10,ExtraBonus,Bonus1Type,Bonus2Type,Bonus3Type,Bonus4Type,Bonus5Type,Bonus6Type,Bonus7Type,Bonus8Type,Bonus9Type,Bonus10Type,ExtraBonusType,IsPickable,IsDropable,CanDropAsLoot,IsTradable,Platinum,Gold,Silver,Copper,MaxCount,PackSize,Charges,MaxCharges,Charges1,MaxCharges1,SpellID,SpellID1,ProcSpellID,ProcSpellID1,PoisonSpellID,PoisonMaxCharges,PoisonCharges,Realm,AllowedClasses) VALUES (?ItemTemplate_ID,?Id_nb,?Name,?Level,?Durability,?MaxDurability,?Condition,?MaxCondition,?Quality,?DPS_AF,?SPD_ABS,?Hand,?Type_Damage,?Object_Type,?Item_Type,?Color,?Emblem,?Effect,?Weight,?Model,?Extension,?Bonus,?Bonus1,?Bonus2,?Bonus3,?Bonus4,?Bonus5,?Bonus6,?Bonus7,?Bonus8,?Bonus9,?Bonus10,?ExtraBonus,?Bonus1Type,?Bonus2Type,?Bonus3Type,?Bonus4Type,?Bonus5Type,?Bonus6Type,?Bonus7Type,?Bonus8Type,?Bonus9Type,?Bonus10Type,?ExtraBonusType,?IsPickable,?IsDropable,?CanDropAsLoot,?IsTradable,?Platinum,?Gold,?Silver,?Copper,?MaxCount,?PackSize,?Charges,?MaxCharges,?Charges1,?MaxCharges1,?SpellID,?SpellID1,?ProcSpellID,?ProcSpellID1,?PoisonSpellID,?PoisonMaxCharges,?PoisonCharges,?Realm,?AllowedClasses)";

			cmd.CommandText = SQL;

			cmd.Parameters.AddWithValue("?ItemTemplate_ID",ItemTemplate_ID);
            cmd.Parameters.AddWithValue("?Id_nb", Id_nb);
            cmd.Parameters.AddWithValue("?Name", Name);
			cmd.Parameters.AddWithValue("?Level",Level);
            cmd.Parameters.AddWithValue("?Durability", Durability);
            cmd.Parameters.AddWithValue("?MaxDurability",MaxDurability);
			cmd.Parameters.AddWithValue("?Condition",Condition);
			cmd.Parameters.AddWithValue("?MaxCondition",MaxCondition);
			cmd.Parameters.AddWithValue("?Quality",Quality);
			cmd.Parameters.AddWithValue("?DPS_AF",DPS_AF);
			cmd.Parameters.AddWithValue("?SPD_ABS",SPD_ABS);
			cmd.Parameters.AddWithValue("?Hand",Hand);
			cmd.Parameters.AddWithValue("?Type_Damage",Type_Damage);
			cmd.Parameters.AddWithValue("?Object_Type",Object_Type);
			cmd.Parameters.AddWithValue("?Item_Type",Item_Type);
			cmd.Parameters.AddWithValue("?Color",Color);
			cmd.Parameters.AddWithValue("?Emblem",Emblem);
			cmd.Parameters.AddWithValue("?Effect",Effect);
			cmd.Parameters.AddWithValue("?Weight",Weight);
			cmd.Parameters.AddWithValue("?Model",Model);
			cmd.Parameters.AddWithValue("?Extension",Extension);
			cmd.Parameters.AddWithValue("?Bonus",Bonus);
			cmd.Parameters.AddWithValue("?Bonus1",Bonus1);
			cmd.Parameters.AddWithValue("?Bonus2",Bonus2);
			cmd.Parameters.AddWithValue("?Bonus3",Bonus3);
			cmd.Parameters.AddWithValue("?Bonus4",Bonus4);
			cmd.Parameters.AddWithValue("?Bonus5",Bonus5);
			cmd.Parameters.AddWithValue("?Bonus6",Bonus6);
			cmd.Parameters.AddWithValue("?Bonus7",Bonus7);
			cmd.Parameters.AddWithValue("?Bonus8",Bonus8);
			cmd.Parameters.AddWithValue("?Bonus9",Bonus9);
			cmd.Parameters.AddWithValue("?Bonus10",Bonus10);
			cmd.Parameters.AddWithValue("?ExtraBonus",ExtraBonus);
			cmd.Parameters.AddWithValue("?Bonus1Type",Bonus1Type);
			cmd.Parameters.AddWithValue("?Bonus2Type",Bonus2Type);
			cmd.Parameters.AddWithValue("?Bonus3Type",Bonus3Type);
			cmd.Parameters.AddWithValue("?Bonus4Type",Bonus4Type);
			cmd.Parameters.AddWithValue("?Bonus5Type",Bonus5Type);
			cmd.Parameters.AddWithValue("?Bonus6Type",Bonus6Type);
			cmd.Parameters.AddWithValue("?Bonus7Type",Bonus7Type);
			cmd.Parameters.AddWithValue("?Bonus8Type",Bonus8Type);
			cmd.Parameters.AddWithValue("?Bonus9Type",Bonus9Type);
			cmd.Parameters.AddWithValue("?Bonus10Type",Bonus10Type);
			cmd.Parameters.AddWithValue("?ExtraBonusType",ExtraBonusType);
			cmd.Parameters.AddWithValue("?IsPickable",IsPickable);
			cmd.Parameters.AddWithValue("?IsDropable",IsDropable);
			cmd.Parameters.AddWithValue("?CanDropAsLoot",CanDropAsLoot);
			cmd.Parameters.AddWithValue("?IsTradable",IsTradable);
			cmd.Parameters.AddWithValue("?Platinum",Platinum);
			cmd.Parameters.AddWithValue("?Gold",Gold);
			cmd.Parameters.AddWithValue("?Silver",Silver);
			cmd.Parameters.AddWithValue("?Copper",Copper);
			cmd.Parameters.AddWithValue("?MaxCount",MaxCount);
			cmd.Parameters.AddWithValue("?PackSize",PackSize);
			cmd.Parameters.AddWithValue("?Charges",Charges);
			cmd.Parameters.AddWithValue("?MaxCharges",MaxCharges);
			cmd.Parameters.AddWithValue("?Charges1",Charges1);
			cmd.Parameters.AddWithValue("?MaxCharges1",MaxCharges1);
			cmd.Parameters.AddWithValue("?SpellID",SpellID);
			cmd.Parameters.AddWithValue("?SpellID1",SpellID1);
			cmd.Parameters.AddWithValue("?ProcSpellID",ProcSpellID);
			cmd.Parameters.AddWithValue("?ProcSpellID1",ProcSpellID1);
			cmd.Parameters.AddWithValue("?PoisonSpellID",PoisonSpellID);
			cmd.Parameters.AddWithValue("?PoisonMaxCharges",PoisonMaxCharges);
			cmd.Parameters.AddWithValue("?PoisonCharges",PoisonCharges);
			cmd.Parameters.AddWithValue("?Realm",Realm);
            cmd.Parameters.AddWithValue("?AllowedClasses", AllowedClasses);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}

		/// <summary>
		/// Method for updating row in database table ITEMTEMPLATE.
		/// </summary>
		public void Update()
		{
            MySqlConnection con = _Connection;
			MySqlCommand cmd = con.CreateCommand();

            string SQL = "UPDATE itemtemplate SET Id_nb = ?Id_nb,Name = ?Name,Level = ?Level,Durability = ?Durability,MaxDurability = ?MaxDurability,`Condition` = ?Condition,MaxCondition = ?MaxCondition,Quality = ?Quality,DPS_AF = ?DPS_AF,SPD_ABS = ?SPD_ABS,Hand = ?Hand,Type_Damage = ?Type_Damage,Object_Type = ?Object_Type,Item_Type = ?Item_Type,Color = ?Color,Emblem = ?Emblem,Effect = ?Effect,Weight = ?Weight,Model = ?Model,Extension = ?Extension,Bonus = ?Bonus,Bonus1 = ?Bonus1,Bonus2 = ?Bonus2,Bonus3 = ?Bonus3,Bonus4 = ?Bonus4,Bonus5 = ?Bonus5,Bonus6 = ?Bonus6,Bonus7 = ?Bonus7,Bonus8 = ?Bonus8,Bonus9 = ?Bonus9,Bonus10 = ?Bonus10,ExtraBonus = ?ExtraBonus,Bonus1Type = ?Bonus1Type,Bonus2Type = ?Bonus2Type,Bonus3Type = ?Bonus3Type,Bonus4Type = ?Bonus4Type,Bonus5Type = ?Bonus5Type,Bonus6Type = ?Bonus6Type,Bonus7Type = ?Bonus7Type,Bonus8Type = ?Bonus8Type,Bonus9Type = ?Bonus9Type,Bonus10Type = ?Bonus10Type,ExtraBonusType = ?ExtraBonusType,IsPickable = ?IsPickable,IsDropable = ?IsDropable,CanDropAsLoot = ?CanDropAsLoot,IsTradable = ?IsTradable,Platinum = ?Platinum,Gold = ?Gold,Silver = ?Silver,Copper = ?Copper,MaxCount = ?MaxCount,PackSize = ?PackSize,Charges = ?Charges,MaxCharges = ?MaxCharges,Charges1 = ?Charges1,MaxCharges1 = ?MaxCharges1,SpellID = ?SpellID,SpellID1 = ?SpellID1,ProcSpellID = ?ProcSpellID,ProcSpellID1 = ?ProcSpellID1,PoisonSpellID = ?PoisonSpellID,PoisonMaxCharges = ?PoisonMaxCharges,PoisonCharges = ?PoisonCharges,Realm = ?Realm,AllowedClasses = ?AllowedClasses WHERE ItemTemplate_ID = ?ItemTemplate_ID;";

			cmd.CommandText = SQL;

			cmd.Parameters.AddWithValue("?ItemTemplate_ID",ItemTemplate_ID);
			cmd.Parameters.AddWithValue("?Id_nb",Id_nb);
			cmd.Parameters.AddWithValue("?Name",Name);
			cmd.Parameters.AddWithValue("?Level",Level);
            cmd.Parameters.AddWithValue("?Durability", Durability);
            cmd.Parameters.AddWithValue("?MaxDurability",MaxDurability);
			cmd.Parameters.AddWithValue("?Condition",Condition);
			cmd.Parameters.AddWithValue("?MaxCondition",MaxCondition);
			cmd.Parameters.AddWithValue("?Quality",Quality);
			cmd.Parameters.AddWithValue("?DPS_AF",DPS_AF);
			cmd.Parameters.AddWithValue("?SPD_ABS",SPD_ABS);
			cmd.Parameters.AddWithValue("?Hand",Hand);
			cmd.Parameters.AddWithValue("?Type_Damage",Type_Damage);
			cmd.Parameters.AddWithValue("?Object_Type",Object_Type);
			cmd.Parameters.AddWithValue("?Item_Type",Item_Type);
			cmd.Parameters.AddWithValue("?Color",Color);
			cmd.Parameters.AddWithValue("?Emblem",Emblem);
			cmd.Parameters.AddWithValue("?Effect",Effect);
			cmd.Parameters.AddWithValue("?Weight",Weight);
			cmd.Parameters.AddWithValue("?Model",Model);
			cmd.Parameters.AddWithValue("?Extension",Extension);
			cmd.Parameters.AddWithValue("?Bonus",Bonus);
			cmd.Parameters.AddWithValue("?Bonus1",Bonus1);
			cmd.Parameters.AddWithValue("?Bonus2",Bonus2);
			cmd.Parameters.AddWithValue("?Bonus3",Bonus3);
			cmd.Parameters.AddWithValue("?Bonus4",Bonus4);
			cmd.Parameters.AddWithValue("?Bonus5",Bonus5);
			cmd.Parameters.AddWithValue("?Bonus6",Bonus6);
			cmd.Parameters.AddWithValue("?Bonus7",Bonus7);
			cmd.Parameters.AddWithValue("?Bonus8",Bonus8);
			cmd.Parameters.AddWithValue("?Bonus9",Bonus9);
			cmd.Parameters.AddWithValue("?Bonus10",Bonus10);
			cmd.Parameters.AddWithValue("?ExtraBonus",ExtraBonus);
			cmd.Parameters.AddWithValue("?Bonus1Type",Bonus1Type);
			cmd.Parameters.AddWithValue("?Bonus2Type",Bonus2Type);
			cmd.Parameters.AddWithValue("?Bonus3Type",Bonus3Type);
			cmd.Parameters.AddWithValue("?Bonus4Type",Bonus4Type);
			cmd.Parameters.AddWithValue("?Bonus5Type",Bonus5Type);
			cmd.Parameters.AddWithValue("?Bonus6Type",Bonus6Type);
			cmd.Parameters.AddWithValue("?Bonus7Type",Bonus7Type);
			cmd.Parameters.AddWithValue("?Bonus8Type",Bonus8Type);
			cmd.Parameters.AddWithValue("?Bonus9Type",Bonus9Type);
			cmd.Parameters.AddWithValue("?Bonus10Type",Bonus10Type);
			cmd.Parameters.AddWithValue("?ExtraBonusType",ExtraBonusType);
			cmd.Parameters.AddWithValue("?IsPickable",IsPickable);
			cmd.Parameters.AddWithValue("?IsDropable",IsDropable);
			cmd.Parameters.AddWithValue("?CanDropAsLoot",CanDropAsLoot);
			cmd.Parameters.AddWithValue("?IsTradable",IsTradable);
			cmd.Parameters.AddWithValue("?Platinum",Platinum);
			cmd.Parameters.AddWithValue("?Gold",Gold);
			cmd.Parameters.AddWithValue("?Silver",Silver);
			cmd.Parameters.AddWithValue("?Copper",Copper);
			cmd.Parameters.AddWithValue("?MaxCount",MaxCount);
			cmd.Parameters.AddWithValue("?PackSize",PackSize);
			cmd.Parameters.AddWithValue("?Charges",Charges);
			cmd.Parameters.AddWithValue("?MaxCharges",MaxCharges);
			cmd.Parameters.AddWithValue("?Charges1",Charges1);
			cmd.Parameters.AddWithValue("?MaxCharges1",MaxCharges1);
			cmd.Parameters.AddWithValue("?SpellID",SpellID);
			cmd.Parameters.AddWithValue("?SpellID1",SpellID1);
			cmd.Parameters.AddWithValue("?ProcSpellID",ProcSpellID);
			cmd.Parameters.AddWithValue("?ProcSpellID1",ProcSpellID1);
			cmd.Parameters.AddWithValue("?PoisonSpellID",PoisonSpellID);
			cmd.Parameters.AddWithValue("?PoisonMaxCharges",PoisonMaxCharges);
			cmd.Parameters.AddWithValue("?PoisonCharges",PoisonCharges);
			cmd.Parameters.AddWithValue("?Realm",Realm);
            cmd.Parameters.AddWithValue("?AllowedClasses",AllowedClasses);
			cmd.Parameters.AddWithValue("ItemTemplate_ID",ItemTemplate_ID);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}

        public void UpdateByKeyname()
        {
            MySqlConnection con = _Connection;
            MySqlCommand cmd = con.CreateCommand();

            string SQL = "UPDATE itemtemplate SET Name = ?Name,Level = ?Level,Durability = ?Durability,MaxDurability = ?MaxDurability,`Condition` = ?Condition,MaxCondition = ?MaxCondition,Quality = ?Quality,DPS_AF = ?DPS_AF,SPD_ABS = ?SPD_ABS,Hand = ?Hand,Type_Damage = ?Type_Damage,Object_Type = ?Object_Type,Item_Type = ?Item_Type,Color = ?Color,Emblem = ?Emblem,Effect = ?Effect,Weight = ?Weight,Model = ?Model,Extension = ?Extension,Bonus = ?Bonus,Bonus1 = ?Bonus1,Bonus2 = ?Bonus2,Bonus3 = ?Bonus3,Bonus4 = ?Bonus4,Bonus5 = ?Bonus5,Bonus6 = ?Bonus6,Bonus7 = ?Bonus7,Bonus8 = ?Bonus8,Bonus9 = ?Bonus9,Bonus10 = ?Bonus10,ExtraBonus = ?ExtraBonus,Bonus1Type = ?Bonus1Type,Bonus2Type = ?Bonus2Type,Bonus3Type = ?Bonus3Type,Bonus4Type = ?Bonus4Type,Bonus5Type = ?Bonus5Type,Bonus6Type = ?Bonus6Type,Bonus7Type = ?Bonus7Type,Bonus8Type = ?Bonus8Type,Bonus9Type = ?Bonus9Type,Bonus10Type = ?Bonus10Type,ExtraBonusType = ?ExtraBonusType,IsPickable = ?IsPickable,IsDropable = ?IsDropable,CanDropAsLoot = ?CanDropAsLoot,IsTradable = ?IsTradable,Platinum = ?Platinum,Gold = ?Gold,Silver = ?Silver,Copper = ?Copper,MaxCount = ?MaxCount,PackSize = ?PackSize,Charges = ?Charges,MaxCharges = ?MaxCharges,Charges1 = ?Charges1,MaxCharges1 = ?MaxCharges1,SpellID = ?SpellID,SpellID1 = ?SpellID1,ProcSpellID = ?ProcSpellID,ProcSpellID1 = ?ProcSpellID1,PoisonSpellID = ?PoisonSpellID,PoisonMaxCharges = ?PoisonMaxCharges,PoisonCharges = ?PoisonCharges,Realm = ?Realm,AllowedClasses = ?AllowedClasses WHERE Id_nb = ?Id_nb;";

            cmd.CommandText = SQL;

            cmd.Parameters.AddWithValue("?ItemTemplate_ID", ItemTemplate_ID);
            cmd.Parameters.AddWithValue("?Id_nb", Id_nb);
            cmd.Parameters.AddWithValue("?Name", Name);
            cmd.Parameters.AddWithValue("?Level", Level);
            cmd.Parameters.AddWithValue("?Durability", Durability);
            cmd.Parameters.AddWithValue("?MaxDurability", MaxDurability);
            cmd.Parameters.AddWithValue("?Condition", Condition);
            cmd.Parameters.AddWithValue("?MaxCondition", MaxCondition);
            cmd.Parameters.AddWithValue("?Quality", Quality);
            cmd.Parameters.AddWithValue("?DPS_AF", DPS_AF);
            cmd.Parameters.AddWithValue("?SPD_ABS", SPD_ABS);
            cmd.Parameters.AddWithValue("?Hand", Hand);
            cmd.Parameters.AddWithValue("?Type_Damage", Type_Damage);
            cmd.Parameters.AddWithValue("?Object_Type", Object_Type);
            cmd.Parameters.AddWithValue("?Item_Type", Item_Type);
            cmd.Parameters.AddWithValue("?Color", Color);
            cmd.Parameters.AddWithValue("?Emblem", Emblem);
            cmd.Parameters.AddWithValue("?Effect", Effect);
            cmd.Parameters.AddWithValue("?Weight", Weight);
            cmd.Parameters.AddWithValue("?Model", Model);
            cmd.Parameters.AddWithValue("?Extension", Extension);
            cmd.Parameters.AddWithValue("?Bonus", Bonus);
            cmd.Parameters.AddWithValue("?Bonus1", Bonus1);
            cmd.Parameters.AddWithValue("?Bonus2", Bonus2);
            cmd.Parameters.AddWithValue("?Bonus3", Bonus3);
            cmd.Parameters.AddWithValue("?Bonus4", Bonus4);
            cmd.Parameters.AddWithValue("?Bonus5", Bonus5);
            cmd.Parameters.AddWithValue("?Bonus6", Bonus6);
            cmd.Parameters.AddWithValue("?Bonus7", Bonus7);
            cmd.Parameters.AddWithValue("?Bonus8", Bonus8);
            cmd.Parameters.AddWithValue("?Bonus9", Bonus9);
            cmd.Parameters.AddWithValue("?Bonus10", Bonus10);
            cmd.Parameters.AddWithValue("?ExtraBonus", ExtraBonus);
            cmd.Parameters.AddWithValue("?Bonus1Type", Bonus1Type);
            cmd.Parameters.AddWithValue("?Bonus2Type", Bonus2Type);
            cmd.Parameters.AddWithValue("?Bonus3Type", Bonus3Type);
            cmd.Parameters.AddWithValue("?Bonus4Type", Bonus4Type);
            cmd.Parameters.AddWithValue("?Bonus5Type", Bonus5Type);
            cmd.Parameters.AddWithValue("?Bonus6Type", Bonus6Type);
            cmd.Parameters.AddWithValue("?Bonus7Type", Bonus7Type);
            cmd.Parameters.AddWithValue("?Bonus8Type", Bonus8Type);
            cmd.Parameters.AddWithValue("?Bonus9Type", Bonus9Type);
            cmd.Parameters.AddWithValue("?Bonus10Type", Bonus10Type);
            cmd.Parameters.AddWithValue("?ExtraBonusType", ExtraBonusType);
            cmd.Parameters.AddWithValue("?IsPickable", IsPickable);
            cmd.Parameters.AddWithValue("?IsDropable", IsDropable);
            cmd.Parameters.AddWithValue("?CanDropAsLoot", CanDropAsLoot);
            cmd.Parameters.AddWithValue("?IsTradable", IsTradable);
            cmd.Parameters.AddWithValue("?Platinum", Platinum);
            cmd.Parameters.AddWithValue("?Gold", Gold);
            cmd.Parameters.AddWithValue("?Silver", Silver);
            cmd.Parameters.AddWithValue("?Copper", Copper);
            cmd.Parameters.AddWithValue("?MaxCount", MaxCount);
            cmd.Parameters.AddWithValue("?PackSize", PackSize);
            cmd.Parameters.AddWithValue("?Charges", Charges);
            cmd.Parameters.AddWithValue("?MaxCharges", MaxCharges);
            cmd.Parameters.AddWithValue("?Charges1", Charges1);
            cmd.Parameters.AddWithValue("?MaxCharges1", MaxCharges1);
            cmd.Parameters.AddWithValue("?SpellID", SpellID);
            cmd.Parameters.AddWithValue("?SpellID1", SpellID1);
            cmd.Parameters.AddWithValue("?ProcSpellID", ProcSpellID);
            cmd.Parameters.AddWithValue("?ProcSpellID1", ProcSpellID1);
            cmd.Parameters.AddWithValue("?PoisonSpellID", PoisonSpellID);
            cmd.Parameters.AddWithValue("?PoisonMaxCharges", PoisonMaxCharges);
            cmd.Parameters.AddWithValue("?PoisonCharges", PoisonCharges);
            cmd.Parameters.AddWithValue("?Realm", Realm);
            cmd.Parameters.AddWithValue("?AllowedClasses", AllowedClasses);
            cmd.Parameters.AddWithValue("ItemTemplate_ID", ItemTemplate_ID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

		/// <summary>
		/// Method for deleting row in database table ITEMTEMPLATE.
		/// </summary>
		/*
        public void Delete()
		{
            MySqlConnection con = _Connection;
			MySqlCommand cmd = con.CreateCommand();

			string SQL = "DELETE FROM itemtemplate WHERE ItemTemplate_ID = ?ItemTemplate_ID;";

			cmd.CommandText = SQL;

			cmd.Parameters.AddWithValue("?ItemTemplate_ID",ItemTemplate_ID);

			con.Open();
			cmd.ExecuteNonQuery();
			con.Close();
		}
        */
		/// <summary>
		/// Method for returning SELECT SQL queries from database.
		/// </summary>
		/// <param name="SQLQuery">
		/// SQL query.
		/// </param>
		/// <returns>
		/// Returns a DataSet with the results of the SQL query.
		/// </returns>
		public DataSet Select(string SQLQuery)
		{
            MySqlConnection con = _Connection;
			MySqlDataAdapter adpt = new MySqlDataAdapter(SQLQuery,con);

			DataSet ds = new DataSet();
			adpt.Fill(ds);

			return ds;
		}

        private string getParsedUpdateSQL(string key, object value, bool first)
        {
            if(first) return key + " = " + value.ToString();
            else return ", "+key + " = " + value.ToString();
        }
        private string getParsedInsertSQL(object value, bool first)
        {
            if (first) return value.ToString();
            else return ", " + value.ToString();
        }

        public string getInsertSQL()
        {
            string sql = "INSERT INTO itemtemplate (ItemTemplate_ID,Id_nb,Name,Level,Durability,MaxDurability,`Condition`,MaxCondition,Quality,DPS_AF,SPD_ABS,Hand,Type_Damage,Object_Type,Item_Type,Color,Emblem,Effect,Weight,Model,Extension,Bonus,Bonus1,Bonus2,Bonus3,Bonus4,Bonus5,Bonus6,Bonus7,Bonus8,Bonus9,Bonus10,ExtraBonus,Bonus1Type,Bonus2Type,Bonus3Type,Bonus4Type,Bonus5Type,Bonus6Type,Bonus7Type,Bonus8Type,Bonus9Type,Bonus10Type,ExtraBonusType,IsPickable,IsDropable,CanDropAsLoot,IsTradable,Platinum,Gold,Silver,Copper,MaxCount,PackSize,Charges,MaxCharges,Charges1,MaxCharges1,SpellID,SpellID1,ProcSpellID,ProcSpellID1,PoisonSpellID,PoisonMaxCharges,PoisonCharges,Realm) VALUES ('?ItemTemplate_ID', '?Id_nb', '?Name', '?Level', '?Durability', '?MaxDurability', '?Condition', '?MaxCondition', '?Quality', '?DPS_AF', '?SPD_ABS', '?Hand', '?Type_Damage', '?Object_Type', '?Item_Type', '?Color', '?Emblem', '?Effect', '?Weight', '?Model', '?Extension', '?Bonus', '?Bonus1', '?Bonus2', '?Bonus3', '?Bonus4', '?Bonus5', '?Bonus6', '?Bonus7', '?Bonus8', '?Bonus9', '?Bonus10', '?ExtraBonus', '?Bonus1Type', '?Bonus2Type', '?Bonus3Type', '?Bonus4Type', '?Bonus5Type', '?Bonus6Type', '?Bonus7Type', '?Bonus8Type', '?Bonus9Type', '?Bonus10Type', '?ExtraBonusType', '?IsPickable', '?IsDropable', '?CanDropAsLoot', '?IsTradable', '?Platinum', '?Gold', '?Silver', '?Copper', '?MaxCount', '?PackSize', '?Charges', '?MaxCharges', '?Charges1', '?MaxCharges1', '?SpellID', '?SpellID1', '?ProcSpellID', '?ProcSpellID1', '?PoisonSpellID', '?PoisonMaxCharges', '?PoisonCharges', '?Realm', '?AllowedClasses')";

            sql = sql.Replace("'?ItemTemplate_ID'", "'"+ItemTemplate_ID+"'");
            sql = sql.Replace("'?Id_nb'", "'"+Id_nb+"'");
            sql = sql.Replace("'?Name'", "'"+Name+"'");
            sql = sql.Replace("'?Level'", "'"+Level+"'");
            sql = sql.Replace("'?Durability'", "'"+Durability+"'");
            sql = sql.Replace("'?MaxDurability'", "'"+MaxDurability+"'");
            sql = sql.Replace("'?Condition'", "'"+Condition+"'");
            sql = sql.Replace("'?MaxCondition'", "'"+MaxCondition+"'");
            sql = sql.Replace("'?Quality'", "'"+Quality+"'");
            sql = sql.Replace("'?DPS_AF'", "'"+DPS_AF+"'");
            sql = sql.Replace("'?SPD_ABS'", "'"+SPD_ABS+"'");
            sql = sql.Replace("'?Hand'", "'"+Hand+"'");
            sql = sql.Replace("'?Type_Damage'", "'"+Type_Damage+"'");
            sql = sql.Replace("'?Object_Type'", "'"+Object_Type+"'");
            sql = sql.Replace("'?Item_Type'", "'"+Item_Type+"'");
            sql = sql.Replace("'?Color'", "'"+Color+"'");
            sql = sql.Replace("'?Emblem'", "'"+Emblem+"'");
            sql = sql.Replace("'?Effect'", "'"+Effect+"'");
            sql = sql.Replace("'?Weight'", "'"+Weight+"'");
            sql = sql.Replace("'?Model'", "'"+Model+"'");
            sql = sql.Replace("'?Extension'", "'"+Extension+"'");
            sql = sql.Replace("'?Bonus'", "'"+Bonus+"'");
            sql = sql.Replace("'?Bonus1'", "'"+Bonus1+"'");
            sql = sql.Replace("'?Bonus2'", "'"+Bonus2+"'");
            sql = sql.Replace("'?Bonus3'", "'"+Bonus3+"'");
            sql = sql.Replace("'?Bonus4'", "'"+Bonus4+"'");
            sql = sql.Replace("'?Bonus5'", "'"+Bonus5+"'");
            sql = sql.Replace("'?Bonus6'", "'"+Bonus6+"'");
            sql = sql.Replace("'?Bonus7'", "'"+Bonus7+"'");
            sql = sql.Replace("'?Bonus8'", "'"+Bonus8+"'");
            sql = sql.Replace("'?Bonus9'", "'"+Bonus9+"'");
            sql = sql.Replace("'?Bonus10'", "'"+Bonus10+"'");
            sql = sql.Replace("'?ExtraBonus'", "'"+ExtraBonus+"'");
            sql = sql.Replace("'?Bonus1Type'", "'"+Bonus1Type+"'");
            sql = sql.Replace("'?Bonus2Type'", "'"+Bonus2Type+"'");
            sql = sql.Replace("'?Bonus3Type'", "'"+Bonus3Type+"'");
            sql = sql.Replace("'?Bonus4Type'", "'"+Bonus4Type+"'");
            sql = sql.Replace("'?Bonus5Type'", "'"+Bonus5Type+"'");
            sql = sql.Replace("'?Bonus6Type'", "'"+Bonus6Type+"'");
            sql = sql.Replace("'?Bonus7Type'", "'"+Bonus7Type+"'");
            sql = sql.Replace("'?Bonus8Type'", "'"+Bonus8Type+"'");
            sql = sql.Replace("'?Bonus9Type'", "'"+Bonus9Type+"'");
            sql = sql.Replace("'?Bonus10Type'", "'"+Bonus10Type+"'");
            sql = sql.Replace("'?ExtraBonusType'", "'"+ExtraBonusType+"'");
            sql = sql.Replace("'?IsPickable'", "'"+Convert.ToInt32(IsPickable)+"'");
            sql = sql.Replace("'?IsDropable'", "'"+Convert.ToInt32(IsDropable)+"'");
            sql = sql.Replace("'?CanDropAsLoot'", "'"+Convert.ToInt32(CanDropAsLoot)+"'");
            sql = sql.Replace("'?IsTradable'", "'"+Convert.ToInt32(IsTradable)+"'");
            sql = sql.Replace("'?Platinum'", "'"+Platinum+"'");
            sql = sql.Replace("'?Gold'", "'"+Gold+"'");
            sql = sql.Replace("'?Silver'", "'"+Silver+"'");
            sql = sql.Replace("'?Copper'", "'"+Copper+"'");
            sql = sql.Replace("'?MaxCount'", "'"+MaxCount+"'");
            sql = sql.Replace("'?PackSize'", "'"+PackSize+"'");
            sql = sql.Replace("'?Charges'", "'"+Charges+"'");
            sql = sql.Replace("'?MaxCharges'", "'"+MaxCharges+"'");
            sql = sql.Replace("'?Charges1'", "'"+Charges1+"'");
            sql = sql.Replace("'?MaxCharges1'", "'"+MaxCharges1+"'");
            sql = sql.Replace("'?SpellID'", "'"+SpellID+"'");
            sql = sql.Replace("'?SpellID1'", "'"+SpellID1+"'");
            sql = sql.Replace("'?ProcSpellID'", "'"+ProcSpellID+"'");
            sql = sql.Replace("'?ProcSpellID1'", "'"+ProcSpellID1+"'");
            sql = sql.Replace("'?PoisonSpellID'", "'"+PoisonSpellID+"'");
            sql = sql.Replace("'?PoisonMaxCharges'", "'"+PoisonMaxCharges+"'");
            sql = sql.Replace("'?PoisonCharges'", "'"+PoisonCharges+"'");
            sql = sql.Replace("'?Realm'", "'"+Realm+"'");
            sql = sql.Replace("'?AllowedClasses'", "'" + AllowedClasses + "'");

            return sql;
        }

        public string getUpdateSQL()
        {
            string sql = "UPDATE itemtemplate SET Id_nb = '?Id_nb', Name = '?Name', Level = '?Level', Durability = '?Durability', MaxDurability = '?MaxDurability', `Condition` = '?Condition', MaxCondition = '?MaxCondition', Quality = '?Quality', DPS_AF = '?DPS_AF', SPD_ABS = '?SPD_ABS', Hand = '?Hand', Type_Damage = '?Type_Damage', Object_Type = '?Object_Type', Item_Type = '?Item_Type', Color = '?Color', Emblem = '?Emblem', Effect = '?Effect', Weight = '?Weight', Model = '?Model', Extension = '?Extension', Bonus = '?Bonus', Bonus1 = '?Bonus1', Bonus2 = '?Bonus2', Bonus3 = '?Bonus3', Bonus4 = '?Bonus4', Bonus5 = '?Bonus5', Bonus6 = '?Bonus6', Bonus7 = '?Bonus7', Bonus8 = '?Bonus8', Bonus9 = '?Bonus9', Bonus10 = '?Bonus10', ExtraBonus = '?ExtraBonus', Bonus1Type = '?Bonus1Type', Bonus2Type = '?Bonus2Type', Bonus3Type = '?Bonus3Type', Bonus4Type = '?Bonus4Type', Bonus5Type = '?Bonus5Type', Bonus6Type = '?Bonus6Type', Bonus7Type = '?Bonus7Type', Bonus8Type = '?Bonus8Type', Bonus9Type = '?Bonus9Type', Bonus10Type = '?Bonus10Type', ExtraBonusType = '?ExtraBonusType', IsPickable = '?IsPickable', IsDropable = '?IsDropable', CanDropAsLoot = '?CanDropAsLoot', IsTradable = '?IsTradable', Platinum = '?Platinum', Gold = '?Gold', Silver = '?Silver', Copper = '?Copper', MaxCount = '?MaxCount', PackSize = '?PackSize', Charges = '?Charges', MaxCharges = '?MaxCharges', Charges1 = '?Charges1', MaxCharges1 = '?MaxCharges1', SpellID = '?SpellID', SpellID1 = '?SpellID1', ProcSpellID = '?ProcSpellID', ProcSpellID1 = '?ProcSpellID1', PoisonSpellID = '?PoisonSpellID', PoisonMaxCharges = '?PoisonMaxCharges', PoisonCharges = '?PoisonCharges', Realm = '?Realm', AllowedClasses = '?AllowedClasses' WHERE ItemTemplate_ID = '?ItemTemplate_ID'";

            sql = sql.Replace("'?ItemTemplate_ID'", "'" + ItemTemplate_ID + "'");
            sql = sql.Replace("'?Id_nb'", "'" + Id_nb + "'");
            sql = sql.Replace("'?Name'", "'" + Name + "'");
            sql = sql.Replace("'?Level'", "'" + Level + "'");
            sql = sql.Replace("'?Durability'", "'" + Durability + "'");
            sql = sql.Replace("'?MaxDurability'", "'" + MaxDurability + "'");
            sql = sql.Replace("'?Condition'", "'" + Condition + "'");
            sql = sql.Replace("'?MaxCondition'", "'" + MaxCondition + "'");
            sql = sql.Replace("'?Quality'", "'" + Quality + "'");
            sql = sql.Replace("'?DPS_AF'", "'" + DPS_AF + "'");
            sql = sql.Replace("'?SPD_ABS'", "'" + SPD_ABS + "'");
            sql = sql.Replace("'?Hand'", "'" + Hand + "'");
            sql = sql.Replace("'?Type_Damage'", "'" + Type_Damage + "'");
            sql = sql.Replace("'?Object_Type'", "'" + Object_Type + "'");
            sql = sql.Replace("'?Item_Type'", "'" + Item_Type + "'");
            sql = sql.Replace("'?Color'", "'" + Color + "'");
            sql = sql.Replace("'?Emblem'", "'" + Emblem + "'");
            sql = sql.Replace("'?Effect'", "'" + Effect + "'");
            sql = sql.Replace("'?Weight'", "'" + Weight + "'");
            sql = sql.Replace("'?Model'", "'" + Model + "'");
            sql = sql.Replace("'?Extension'", "'" + Extension + "'");
            sql = sql.Replace("'?Bonus'", "'" + Bonus + "'");
            sql = sql.Replace("'?Bonus1'", "'" + Bonus1 + "'");
            sql = sql.Replace("'?Bonus2'", "'" + Bonus2 + "'");
            sql = sql.Replace("'?Bonus3'", "'" + Bonus3 + "'");
            sql = sql.Replace("'?Bonus4'", "'" + Bonus4 + "'");
            sql = sql.Replace("'?Bonus5'", "'" + Bonus5 + "'");
            sql = sql.Replace("'?Bonus6'", "'" + Bonus6 + "'");
            sql = sql.Replace("'?Bonus7'", "'" + Bonus7 + "'");
            sql = sql.Replace("'?Bonus8'", "'" + Bonus8 + "'");
            sql = sql.Replace("'?Bonus9'", "'" + Bonus9 + "'");
            sql = sql.Replace("'?Bonus10'", "'" + Bonus10 + "'");
            sql = sql.Replace("'?ExtraBonus'", "'" + ExtraBonus + "'");
            sql = sql.Replace("'?Bonus1Type'", "'" + Bonus1Type + "'");
            sql = sql.Replace("'?Bonus2Type'", "'" + Bonus2Type + "'");
            sql = sql.Replace("'?Bonus3Type'", "'" + Bonus3Type + "'");
            sql = sql.Replace("'?Bonus4Type'", "'" + Bonus4Type + "'");
            sql = sql.Replace("'?Bonus5Type'", "'" + Bonus5Type + "'");
            sql = sql.Replace("'?Bonus6Type'", "'" + Bonus6Type + "'");
            sql = sql.Replace("'?Bonus7Type'", "'" + Bonus7Type + "'");
            sql = sql.Replace("'?Bonus8Type'", "'" + Bonus8Type + "'");
            sql = sql.Replace("'?Bonus9Type'", "'" + Bonus9Type + "'");
            sql = sql.Replace("'?Bonus10Type'", "'" + Bonus10Type + "'");
            sql = sql.Replace("'?ExtraBonusType'", "'" + ExtraBonusType + "'");
            sql = sql.Replace("'?IsPickable'", "'" + Convert.ToInt32(IsPickable) + "'");
            sql = sql.Replace("'?IsDropable'", "'" + Convert.ToInt32(IsDropable) + "'");
            sql = sql.Replace("'?CanDropAsLoot'", "'" + Convert.ToInt32(CanDropAsLoot) + "'");
            sql = sql.Replace("'?IsTradable'", "'" + Convert.ToInt32(IsTradable) + "'");
            sql = sql.Replace("'?Platinum'", "'" + Platinum + "'");
            sql = sql.Replace("'?Gold'", "'" + Gold + "'");
            sql = sql.Replace("'?Silver'", "'" + Silver + "'");
            sql = sql.Replace("'?Copper'", "'" + Copper + "'");
            sql = sql.Replace("'?MaxCount'", "'" + MaxCount + "'");
            sql = sql.Replace("'?PackSize'", "'" + PackSize + "'");
            sql = sql.Replace("'?Charges'", "'" + Charges + "'");
            sql = sql.Replace("'?MaxCharges'", "'" + MaxCharges + "'");
            sql = sql.Replace("'?Charges1'", "'" + Charges1 + "'");
            sql = sql.Replace("'?MaxCharges1'", "'" + MaxCharges1 + "'");
            sql = sql.Replace("'?SpellID'", "'" + SpellID + "'");
            sql = sql.Replace("'?SpellID1'", "'" + SpellID1 + "'");
            sql = sql.Replace("'?ProcSpellID'", "'" + ProcSpellID + "'");
            sql = sql.Replace("'?ProcSpellID1'", "'" + ProcSpellID1 + "'");
            sql = sql.Replace("'?PoisonSpellID'", "'" + PoisonSpellID + "'");
            sql = sql.Replace("'?PoisonMaxCharges'", "'" + PoisonMaxCharges + "'");
            sql = sql.Replace("'?PoisonCharges'", "'" + PoisonCharges + "'");
            sql = sql.Replace("'?Realm'", "'" + Realm + "'");
            sql = sql.Replace("'?AllowedClasses'", "'" + AllowedClasses + "'");

            return sql;
        }

        public string getUpdateByKeynameSQL()
        {
            string sql = "UPDATE itemtemplate SET Name = '?Name', Level = '?Level', Durability = '?Durability', MaxDurability = '?MaxDurability', `Condition` = '?Condition', MaxCondition = '?MaxCondition', Quality = '?Quality', DPS_AF = '?DPS_AF', SPD_ABS = '?SPD_ABS', Hand = '?Hand', Type_Damage = '?Type_Damage', Object_Type = '?Object_Type', Item_Type = '?Item_Type', Color = '?Color', Emblem = '?Emblem', Effect = '?Effect', Weight = '?Weight', Model = '?Model', Extension = '?Extension', Bonus = '?Bonus', Bonus1 = '?Bonus1', Bonus2 = '?Bonus2', Bonus3 = '?Bonus3', Bonus4 = '?Bonus4', Bonus5 = '?Bonus5', Bonus6 = '?Bonus6', Bonus7 = '?Bonus7', Bonus8 = '?Bonus8', Bonus9 = '?Bonus9', Bonus10 = '?Bonus10', ExtraBonus = '?ExtraBonus', Bonus1Type = '?Bonus1Type', Bonus2Type = '?Bonus2Type', Bonus3Type = '?Bonus3Type', Bonus4Type = '?Bonus4Type', Bonus5Type = '?Bonus5Type', Bonus6Type = '?Bonus6Type', Bonus7Type = '?Bonus7Type', Bonus8Type = '?Bonus8Type', Bonus9Type = '?Bonus9Type', Bonus10Type = '?Bonus10Type', ExtraBonusType = '?ExtraBonusType', IsPickable = '?IsPickable', IsDropable = '?IsDropable', CanDropAsLoot = '?CanDropAsLoot', IsTradable = '?IsTradable', Platinum = '?Platinum', Gold = '?Gold', Silver = '?Silver', Copper = '?Copper', MaxCount = '?MaxCount', PackSize = '?PackSize', Charges = '?Charges', MaxCharges = '?MaxCharges', Charges1 = '?Charges1', MaxCharges1 = '?MaxCharges1', SpellID = '?SpellID', SpellID1 = '?SpellID1', ProcSpellID = '?ProcSpellID', ProcSpellID1 = '?ProcSpellID1', PoisonSpellID = '?PoisonSpellID', PoisonMaxCharges = '?PoisonMaxCharges', PoisonCharges = '?PoisonCharges', Realm = '?Realm', AllowedClasses = '?AllowedClasses' WHERE Id_nb = '?Id_nb'";

            sql = sql.Replace("'?ItemTemplate_ID'", "'" + ItemTemplate_ID + "'");
            sql = sql.Replace("'?Id_nb'", "'" + Id_nb + "'");
            sql = sql.Replace("'?Name'", "'" + Name + "'");
            sql = sql.Replace("'?Level'", "'" + Level + "'");
            sql = sql.Replace("'?Durability'", "'" + Durability + "'");
            sql = sql.Replace("'?MaxDurability'", "'" + MaxDurability + "'");
            sql = sql.Replace("'?Condition'", "'" + Condition + "'");
            sql = sql.Replace("'?MaxCondition'", "'" + MaxCondition + "'");
            sql = sql.Replace("'?Quality'", "'" + Quality + "'");
            sql = sql.Replace("'?DPS_AF'", "'" + DPS_AF + "'");
            sql = sql.Replace("'?SPD_ABS'", "'" + SPD_ABS + "'");
            sql = sql.Replace("'?Hand'", "'" + Hand + "'");
            sql = sql.Replace("'?Type_Damage'", "'" + Type_Damage + "'");
            sql = sql.Replace("'?Object_Type'", "'" + Object_Type + "'");
            sql = sql.Replace("'?Item_Type'", "'" + Item_Type + "'");
            sql = sql.Replace("'?Color'", "'" + Color + "'");
            sql = sql.Replace("'?Emblem'", "'" + Emblem + "'");
            sql = sql.Replace("'?Effect'", "'" + Effect + "'");
            sql = sql.Replace("'?Weight'", "'" + Weight + "'");
            sql = sql.Replace("'?Model'", "'" + Model + "'");
            sql = sql.Replace("'?Extension'", "'" + Extension + "'");
            sql = sql.Replace("'?Bonus'", "'" + Bonus + "'");
            sql = sql.Replace("'?Bonus1'", "'" + Bonus1 + "'");
            sql = sql.Replace("'?Bonus2'", "'" + Bonus2 + "'");
            sql = sql.Replace("'?Bonus3'", "'" + Bonus3 + "'");
            sql = sql.Replace("'?Bonus4'", "'" + Bonus4 + "'");
            sql = sql.Replace("'?Bonus5'", "'" + Bonus5 + "'");
            sql = sql.Replace("'?Bonus6'", "'" + Bonus6 + "'");
            sql = sql.Replace("'?Bonus7'", "'" + Bonus7 + "'");
            sql = sql.Replace("'?Bonus8'", "'" + Bonus8 + "'");
            sql = sql.Replace("'?Bonus9'", "'" + Bonus9 + "'");
            sql = sql.Replace("'?Bonus10'", "'" + Bonus10 + "'");
            sql = sql.Replace("'?ExtraBonus'", "'" + ExtraBonus + "'");
            sql = sql.Replace("'?Bonus1Type'", "'" + Bonus1Type + "'");
            sql = sql.Replace("'?Bonus2Type'", "'" + Bonus2Type + "'");
            sql = sql.Replace("'?Bonus3Type'", "'" + Bonus3Type + "'");
            sql = sql.Replace("'?Bonus4Type'", "'" + Bonus4Type + "'");
            sql = sql.Replace("'?Bonus5Type'", "'" + Bonus5Type + "'");
            sql = sql.Replace("'?Bonus6Type'", "'" + Bonus6Type + "'");
            sql = sql.Replace("'?Bonus7Type'", "'" + Bonus7Type + "'");
            sql = sql.Replace("'?Bonus8Type'", "'" + Bonus8Type + "'");
            sql = sql.Replace("'?Bonus9Type'", "'" + Bonus9Type + "'");
            sql = sql.Replace("'?Bonus10Type'", "'" + Bonus10Type + "'");
            sql = sql.Replace("'?ExtraBonusType'", "'" + ExtraBonusType + "'");
            sql = sql.Replace("'?IsPickable'", "'" + Convert.ToInt32(IsPickable) + "'");
            sql = sql.Replace("'?IsDropable'", "'" + Convert.ToInt32(IsDropable) + "'");
            sql = sql.Replace("'?CanDropAsLoot'", "'" + Convert.ToInt32(CanDropAsLoot) + "'");
            sql = sql.Replace("'?IsTradable'", "'" + Convert.ToInt32(IsTradable) + "'");
            sql = sql.Replace("'?Platinum'", "'" + Platinum + "'");
            sql = sql.Replace("'?Gold'", "'" + Gold + "'");
            sql = sql.Replace("'?Silver'", "'" + Silver + "'");
            sql = sql.Replace("'?Copper'", "'" + Copper + "'");
            sql = sql.Replace("'?MaxCount'", "'" + MaxCount + "'");
            sql = sql.Replace("'?PackSize'", "'" + PackSize + "'");
            sql = sql.Replace("'?Charges'", "'" + Charges + "'");
            sql = sql.Replace("'?MaxCharges'", "'" + MaxCharges + "'");
            sql = sql.Replace("'?Charges1'", "'" + Charges1 + "'");
            sql = sql.Replace("'?MaxCharges1'", "'" + MaxCharges1 + "'");
            sql = sql.Replace("'?SpellID'", "'" + SpellID + "'");
            sql = sql.Replace("'?SpellID1'", "'" + SpellID1 + "'");
            sql = sql.Replace("'?ProcSpellID'", "'" + ProcSpellID + "'");
            sql = sql.Replace("'?ProcSpellID1'", "'" + ProcSpellID1 + "'");
            sql = sql.Replace("'?PoisonSpellID'", "'" + PoisonSpellID + "'");
            sql = sql.Replace("'?PoisonMaxCharges'", "'" + PoisonMaxCharges + "'");
            sql = sql.Replace("'?PoisonCharges'", "'" + PoisonCharges + "'");
            sql = sql.Replace("'?Realm'", "'" + Realm + "'");
            sql = sql.Replace("'?AllowedClasses'", "'" + AllowedClasses + "'");

            return sql;
        }
        public string getCSharpCode()
        {
            string code = "";
            code += "ItemTemplate " + Id_nb + " = null;" + Environment.NewLine;
            code += Id_nb + " = (ItemTemplate) GameServer.Database.FindObjectByKey(typeof (ItemTemplate), \"" + Id_nb + "\");" + Environment.NewLine;
            code += "if (" + Id_nb + " == null)" + Environment.NewLine;
            code += "{" + Environment.NewLine;
            code += "   if (log.IsWarnEnabled) log.Warn(\"Could not find " + Name + ", creating it ...\");" + Environment.NewLine;
            if (Id_nb.ToString() != "0" && Id_nb.ToString() != "") code += "    " + Id_nb + ".Id_nb = \"" + Id_nb + "\";" + Environment.NewLine;
            if (Name.ToString() != "0" && Name.ToString() != "") code += "   " + Id_nb + ".Name = \"" + Name + "\";" + Environment.NewLine;
            if (Level.ToString() != "0" && Level.ToString() != "") code += "   " + Id_nb + ".Level = " + Level + ";" + Environment.NewLine;
            if (Durability.ToString() != "0" && Durability.ToString() != "") code += "   " + Id_nb + ".Durability = " + Durability + ";" + Environment.NewLine;
            if (MaxDurability.ToString() != "0" && MaxDurability.ToString() != "") code += "   " + Id_nb + ".MaxDurability = " + MaxDurability + ";" + Environment.NewLine;
            if (Condition.ToString() != "0" && Condition.ToString() != "") code += "   " + Id_nb + ".Condition = " + Condition + ";" + Environment.NewLine;
            if (MaxCondition.ToString() != "0" && MaxCondition.ToString() != "") code += "   " + Id_nb + ".MaxCondition = " + MaxCondition + ";" + Environment.NewLine;
            if (Quality.ToString() != "0" && Quality.ToString() != "") code += "   " + Id_nb + ".Quality = " + Quality + ";" + Environment.NewLine;
            if (DPS_AF.ToString() != "0" && DPS_AF.ToString() != "") code += "   " + Id_nb + ".DPS_AF = " + DPS_AF + ";" + Environment.NewLine;
            if (SPD_ABS.ToString() != "0" && SPD_ABS.ToString() != "") code += "   " + Id_nb + ".SPD_ABS = " + SPD_ABS + ";" + Environment.NewLine;
            if (Hand.ToString() != "0" && Hand.ToString() != "") code += "   " + Id_nb + ".Hand = " + Hand + ";" + Environment.NewLine;
            if (Type_Damage.ToString() != "0" && Type_Damage.ToString() != "") code += "   " + Id_nb + ".Type_Damage = " + Type_Damage + ";" + Environment.NewLine;
            if (Object_Type.ToString() != "0" && Object_Type.ToString() != "") code += "   " + Id_nb + ".Object_Type = " + Object_Type + ";" + Environment.NewLine;
            if (Item_Type.ToString() != "0" && Item_Type.ToString() != "") code += "   " + Id_nb + ".Item_Type = " + Item_Type + ";" + Environment.NewLine;
            if (Color.ToString() != "0" && Color.ToString() != "") code += "   " + Id_nb + ".Color = " + Color + ";" + Environment.NewLine;
            if (Emblem.ToString() != "0" && Emblem.ToString() != "") code += "   " + Id_nb + ".Emblem = " + Emblem + ";" + Environment.NewLine;
            if (Effect.ToString() != "0" && Effect.ToString() != "") code += "   " + Id_nb + ".Effect = " + Effect + ";" + Environment.NewLine;
            if (Weight.ToString() != "0" && Weight.ToString() != "") code += "   " + Id_nb + ".Weight = " + Weight + ";" + Environment.NewLine;
            if (Model.ToString() != "0" && Model.ToString() != "") code += "   " + Id_nb + ".Model = " + Model + ";" + Environment.NewLine;
            if (Extension.ToString() != "0" && Extension.ToString() != "") code += "   " + Id_nb + ".Extension = " + Extension + ";" + Environment.NewLine;
            if (Bonus.ToString() != "0" && Bonus.ToString() != "") code += "   " + Id_nb + ".Bonus = " + Bonus + ";" + Environment.NewLine;
            if (Bonus1.ToString() != "0" && Bonus1.ToString() != "") code += "   " + Id_nb + ".Bonus1 = " + Bonus1 + ";" + Environment.NewLine;
            if (Bonus2.ToString() != "0" && Bonus2.ToString() != "") code += "   " + Id_nb + ".Bonus2 = " + Bonus2 + ";" + Environment.NewLine;
            if (Bonus3.ToString() != "0" && Bonus3.ToString() != "") code += "   " + Id_nb + ".Bonus3 = " + Bonus3 + ";" + Environment.NewLine;
            if (Bonus4.ToString() != "0" && Bonus4.ToString() != "") code += "   " + Id_nb + ".Bonus4 = " + Bonus4 + ";" + Environment.NewLine;
            if (Bonus5.ToString() != "0" && Bonus5.ToString() != "") code += "   " + Id_nb + ".Bonus5 = " + Bonus5 + ";" + Environment.NewLine;
            if (Bonus6.ToString() != "0" && Bonus6.ToString() != "") code += "   " + Id_nb + ".Bonus6 = " + Bonus6 + ";" + Environment.NewLine;
            if (Bonus7.ToString() != "0" && Bonus7.ToString() != "") code += "   " + Id_nb + ".Bonus7 = " + Bonus7 + ";" + Environment.NewLine;
            if (Bonus8.ToString() != "0" && Bonus8.ToString() != "") code += "   " + Id_nb + ".Bonus8 = " + Bonus8 + ";" + Environment.NewLine;
            if (Bonus9.ToString() != "0" && Bonus9.ToString() != "") code += "   " + Id_nb + ".Bonus9 = " + Bonus9 + ";" + Environment.NewLine;
            if (Bonus10.ToString() != "0" && Bonus10.ToString() != "") code += "   " + Id_nb + ".Bonus10 = " + Bonus10 + ";" + Environment.NewLine;
            if (ExtraBonus.ToString() != "0" && ExtraBonus.ToString() != "") code += "   " + Id_nb + ".ExtraBonus = " + ExtraBonus + ";" + Environment.NewLine;
            if (Bonus1Type.ToString() != "0" && Bonus1Type.ToString() != "") code += "   " + Id_nb + ".Bonus1Type = " + Bonus1Type + ";" + Environment.NewLine;
            if (Bonus2Type.ToString() != "0" && Bonus2Type.ToString() != "") code += "   " + Id_nb + ".Bonus2Type = " + Bonus2Type + ";" + Environment.NewLine;
            if (Bonus3Type.ToString() != "0" && Bonus3Type.ToString() != "") code += "   " + Id_nb + ".Bonus3Type = " + Bonus3Type + ";" + Environment.NewLine;
            if (Bonus4Type.ToString() != "0" && Bonus4Type.ToString() != "") code += "   " + Id_nb + ".Bonus4Type = " + Bonus4Type + ";" + Environment.NewLine;
            if (Bonus5Type.ToString() != "0" && Bonus5Type.ToString() != "") code += "   " + Id_nb + ".Bonus5Type = " + Bonus5Type + ";" + Environment.NewLine;
            if (Bonus6Type.ToString() != "0" && Bonus6Type.ToString() != "") code += "   " + Id_nb + ".Bonus6Type = " + Bonus6Type + ";" + Environment.NewLine;
            if (Bonus7Type.ToString() != "0" && Bonus7Type.ToString() != "") code += "   " + Id_nb + ".Bonus7Type = " + Bonus7Type + ";" + Environment.NewLine;
            if (Bonus8Type.ToString() != "0" && Bonus8Type.ToString() != "") code += "   " + Id_nb + ".Bonus8Type = " + Bonus8Type + ";" + Environment.NewLine;
            if (Bonus9Type.ToString() != "0" && Bonus9Type.ToString() != "") code += "   " + Id_nb + ".Bonus9Type = " + Bonus9Type + ";" + Environment.NewLine;
            if (Bonus10Type.ToString() != "0" && Bonus10Type.ToString() != "") code += "   " + Id_nb + ".Bonus10Type = " + Bonus10Type + ";" + Environment.NewLine;
            if (ExtraBonusType.ToString() != "0" && ExtraBonusType.ToString() != "") code += "   " + Id_nb + ".ExtraBonusType = " + ExtraBonusType + ";" + Environment.NewLine;
            if (IsPickable.ToString() != "0" && IsPickable.ToString() != "") code += "   " + Id_nb + ".IsPickable = " + IsPickable.ToString().ToLower() + ";" + Environment.NewLine;
            if (IsDropable.ToString() != "0" && IsDropable.ToString() != "") code += "   " + Id_nb + ".IsDropable = " + IsDropable.ToString().ToLower() + ";" + Environment.NewLine;
            if (CanDropAsLoot.ToString() != "0" && CanDropAsLoot.ToString() != "") code += "   " + Id_nb + ".CanDropAsLoot = " + CanDropAsLoot.ToString().ToLower() + ";" + Environment.NewLine;
            if (IsTradable.ToString() != "0" && IsTradable.ToString() != "") code += "   " + Id_nb + ".IsTradable = " + IsTradable.ToString().ToLower() + ";" + Environment.NewLine;
            if (Platinum.ToString() != "0" && Platinum.ToString() != "") code += "   " + Id_nb + ".Platinum = " + Platinum + ";" + Environment.NewLine;
            if (Gold.ToString() != "0" && Gold.ToString() != "") code += "   " + Id_nb + ".Gold = " + Gold + ";" + Environment.NewLine;
            if (Silver.ToString() != "0" && Silver.ToString() != "") code += "   " + Id_nb + ".Silver = " + Silver + ";" + Environment.NewLine;
            if (Copper.ToString() != "0" && Copper.ToString() != "") code += "   " + Id_nb + ".Copper = " + Copper + ";" + Environment.NewLine;
            if (MaxCount.ToString() != "0" && MaxCount.ToString() != "") code += "   " + Id_nb + ".MaxCount = " + MaxCount + ";" + Environment.NewLine;
            if (PackSize.ToString() != "0" && PackSize.ToString() != "") code += "   " + Id_nb + ".PackSize = " + PackSize + ";" + Environment.NewLine;
            if (Charges.ToString() != "0" && Charges.ToString() != "") code += "   " + Id_nb + ".Charges = " + Charges + ";" + Environment.NewLine;
            if (MaxCharges.ToString() != "0" && MaxCharges.ToString() != "") code += "   " + Id_nb + ".MaxCharges = " + MaxCharges + ";" + Environment.NewLine;
            if (Charges1.ToString() != "0" && Charges1.ToString() != "") code += "   " + Id_nb + ".Charges1 = " + Charges1 + ";" + Environment.NewLine;
            if (MaxCharges1.ToString() != "0" && MaxCharges1.ToString() != "") code += "   " + Id_nb + ".MaxCharges1 = " + MaxCharges1 + ";" + Environment.NewLine;
            if (SpellID.ToString() != "0" && SpellID.ToString() != "") code += "   " + Id_nb + ".SpellID = " + SpellID + ";" + Environment.NewLine;
            if (SpellID1.ToString() != "0" && SpellID1.ToString() != "") code += "   " + Id_nb + ".SpellID1 = " + SpellID1 + ";" + Environment.NewLine;
            if (ProcSpellID.ToString() != "0" && ProcSpellID.ToString() != "") code += "   " + Id_nb + ".ProcSpellID = " + ProcSpellID + ";" + Environment.NewLine;
            if (ProcSpellID1.ToString() != "0" && ProcSpellID1.ToString() != "") code += "   " + Id_nb + ".ProcSpellID1 = " + ProcSpellID1 + ";" + Environment.NewLine;
            if (PoisonSpellID.ToString() != "0" && PoisonSpellID.ToString() != "") code += "   " + Id_nb + ".PoisonSpellID = " + PoisonSpellID + ";" + Environment.NewLine;
            if (PoisonMaxCharges.ToString() != "0" && PoisonMaxCharges.ToString() != "") code += "   " + Id_nb + ".PoisonMaxCharges = " + PoisonMaxCharges + ";" + Environment.NewLine;
            if (PoisonCharges.ToString() != "0" && PoisonCharges.ToString() != "") code += "   " + Id_nb + ".PoisonCharges = " + PoisonCharges + ";" + Environment.NewLine;
            if (Realm.ToString() != "0" && Realm.ToString() != "") code += "   " + Id_nb + ".Realm = " + Realm + ";" + Environment.NewLine;
            if (AllowedClasses.ToString() != "0" && AllowedClasses.ToString() != "") code += "   " + Id_nb + ".AllowedClasses = " + AllowedClasses + ";" + Environment.NewLine;
            code += "   if (SAVE_INTO_DATABASE) GameServer.Database.AddNewObject(" + Id_nb + ");" + Environment.NewLine;
            code += "}" + Environment.NewLine;

            return code;
        }
	}
}
