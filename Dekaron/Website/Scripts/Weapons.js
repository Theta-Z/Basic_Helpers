Weapons = {
	
	Type: {
		ShortSword: 1,
		BigSword: 2,
		ShortAxe: 3,
		BigAxe: 4,
		ShortMace: 5,
		BigMace: 6,
		Bow: 7,
		XBow: 8,
		Wand: 9,
		Staff: 10,
		TwinBlade: 11,
		Whip: 12,
		BagiPowa: 13,
		Spear: 14,
		ConcerraTwinBlade: 15,
		Scythe: 16,
		Orb: 17,
		Falcion: 18,
		Claw: 19,
		Hammer: 20
	},
	
	GetWeaponList: function(){
		return [{
			wid: Weapons.Type.ShortSword,
			weaponName: "Short Sword"
		}, {
			wid: Weapons.Type.BigSword,
			weaponName: "Big Sword"
		}, {
			wid: Weapons.Type.ShortAxe,
			weaponName: "Short Axe"
		}, {
			wid: Weapons.Type.BigAxe,
			weaponName: "Big Axe"
		}, {
			wid: Weapons.Type.ShortMace,
			weaponName: "Short Mace"
		}, {
			wid: Weapons.Type.BigMace,
			weaponName: "Big Mace"
		}, {
			wid: Weapons.Type.Bow,
			weaponName: "Bow"
		}, {
			wid: Weapons.Type.XBow,
			weaponName: "X-Bow"
		}, {
			wid: Weapons.Type.Wand,
			weaponName: "Wand"
		}, {
			wid: Weapons.Type.Staff,
			weaponName: "Staff"
		}, {
			wid: Weapons.Type.TwinBlade,
			weaponName: "Male TwinBlade"
		}, {
			wid: Weapons.Type.ConcerraTwinBlade,
			weaponName: "Female TwinBlade"
		}, {
			wid: Weapons.Type.Whip,
			weaponName: "The White Mage"
		}, {
			wid: Weapons.Type.BagiPowa,
			weaponName: "Bagi POWAAA"
		}, {
			wid: Weapons.Type.Spear,
			weaponName: "Aloken Poke Stick"
		}, {
			wid: Weapons.Type.Scythe,
			weaponName: "Scythe"
		}, {
			wid: Weapons.Type.Orb,
			weaponName: "Male Mage"
		}, {
			wid: Weapons.Type.Falcion,
			weaponName: "Falcion"
		}, {
			wid: Weapons.Type.Claw,
			weaponName: "Female Bagi Claw"
		}, {
			wid: Weapons.Type.Hammer,
			weaponName: "Stop! Hammer Time"
		}];
	},
	
	Get: function(weaponType) {
		switch(weaponType) {
			case Weapons.Type.ShortSword:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 13,
						req2: 7
					}, {
						Level: 12,
						req1: 19,
						req2: 11
					}, {
						Level: 18,
						req1: 26,
						req2: 16
					}, {
						Level: 24,
						req1: 33,
						req2: 21
					}, {
						Level: 30,
						req1: 40,
						req2: 26
					}, {
						Level: 36,
						req1: 48,
						req2: 31
					}, {
						Level: 42,
						req1: 55,
						req2: 35
					}, {
						Level: 48,
						req1: 62,
						req2: 40
					}, {
						Level: 54,
						req1: 69,
						req2: 45
					}, {
						Level: 60,
						req1: 76,
						req2: 50
					}, {
						Level: 66,
						req1: 84,
						req2: 54
					}, {
						Level: 72,
						req1: 91,
						req2: 59
					}, {
						Level: 78,
						req1: 98,
						req2: 64
					}, {
						Level: 85,
						req1: 106,
						req2: 70
					}, {
						Level: 95,
						req1: 118,
						req2: 78
					}, {
						Level: 105,
						req1: 130,
						req2: 86
					}, {
						Level: 115,
						req1: 142,
						req2: 94
					}, {
						Level: 130,
						req1: 160,
						req2: 106
					}, {
						Level: 145,
						req1: 178,
						req2: 118
					}, {
						Level: 160,
						req1: 196,
						req2: 130
					}, {
						Level: 170,
						req1: 208,
						req2: 138
					}
				]};
				break;
				
			case Weapons.Type.BigSword:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 18,
						req2: 9
					}, {
						Level: 16,
						req1: 36,
						req2: 18
					}, {
						Level: 24,
						req1: 52,
						req2: 26
					}, {
						Level: 32,
						req1: 68,
						req2: 34
					}, {
						Level: 40,
						req1: 84,
						req2: 42
					}, {
						Level: 48,
						req1: 100,
						req2: 50
					}, {
						Level: 54,
						req1: 112,
						req2: 56
					}, {
						Level: 60,
						req1: 124,
						req2: 62
					}, {
						Level: 66,
						req1: 136,
						req2: 68
					}, {
						Level: 72,
						req1: 148,
						req2: 74
					}, {
						Level: 78,
						req1: 160,
						req2: 80
					}, {
						Level: 85,
						req1: 174,
						req2: 87
					}, {
						Level: 95,
						req1: 194,
						req2: 97
					}, {
						Level: 105,
						req1: 214,
						req2: 107
					}, {
						Level: 115,
						req1: 234,
						req2: 117
					}, {
						Level: 130,
						req1: 264,
						req2: 132
					}, {
						Level: 145,
						req1: 294,
						req2: 147
					}, {
						Level: 160,
						req1: 234,
						req2: 162
					}, {
						Level: 170,
						req1: 344,
						req2: 172
					}
				]};
				break;
				
			case Weapons.Type.ShortAxe:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 16,
						req2: 7
					}, {
						Level: 12,
						req1: 25,
						req2: 12
					}, {
						Level: 18,
						req1: 36,
						req2: 16
					}, {
						Level: 24,
						req1: 47,
						req2: 21
					}, {
						Level: 30,
						req1: 58,
						req2: 26
					}, {
						Level: 36,
						req1: 69,
						req2: 31
					}, {
						Level: 42,
						req1: 79,
						req2: 36
					}, {
						Level: 48,
						req1: 90,
						req2: 41
					}, {
						Level: 54,
						req1: 101,
						req2: 46
					}, {
						Level: 60,
						req1: 112,
						req2: 51
					}, {
						Level: 66,
						req1: 123,
						req2: 56
					}, {
						Level: 72,
						req1: 91,
						req2: 59
					}, {
						Level: 78,
						req1: 144,
						req2: 66
					}, {
						Level: 85,
						req1: 157,
						req2: 71
					}, {
						Level: 95,
						req1: 175,
						req2: 80
					}, {
						Level: 105,
						req1: 193,
						req2: 88
					}, {
						Level: 115,
						req1: 211,
						req2: 96
					}, {
						Level: 130,
						req1: 238,
						req2: 108
					}, {
						Level: 145,
						req1: 265,
						req2: 121
					}, {
						Level: 160,
						req1: 292,
						req2: 133
					}, {
						Level: 170,
						req1: 310,
						req2: 141
					}
				]};
				break;
				
			case Weapons.Type.BigAxe:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 21,
						req2: 7
					}, {
						Level: 16,
						req1: 43,
						req2: 13
					}, {
						Level: 24,
						req1: 63,
						req2: 18
					}, {
						Level: 32,
						req1: 83,
						req2: 23
					}, {
						Level: 40,
						req1: 103,
						req2: 29
					}, {
						Level: 48,
						req1: 123,
						req2: 34
					}, {
						Level: 54,
						req1: 138,
						req2: 38
					}, {
						Level: 60,
						req1: 153,
						req2: 42
					}, {
						Level: 66,
						req1: 168,
						req2: 45
					}, {
						Level: 72,
						req1: 183,
						req2: 50
					}, {
						Level: 78,
						req1: 198,
						req2: 54
					}, {
						Level: 85,
						req1: 216,
						req2: 59
					}, {
						Level: 95,
						req1: 241,
						req2: 65
					}, {
						Level: 105,
						req1: 266,
						req2: 72
					}, {
						Level: 115,
						req1: 291,
						req2: 79
					}, {
						Level: 130,
						req1: 328,
						req2: 89
					}, {
						Level: 145,
						req1: 366,
						req2: 99
					}, {
						Level: 160,
						req1: 403,
						req2: 109
					}, {
						Level: 170,
						req1: 428,
						req2: 116
					}
				]};
				break;
				
			case Weapons.Type.ShortMace:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 15,
						req2: 8
					}, {
						Level: 12,
						req1: 22,
						req2: 12
					}, {
						Level: 18,
						req1: 31,
						req2: 18
					}, {
						Level: 24,
						req1: 40,
						req2: 23
					}, {
						Level: 30,
						req1: 49,
						req2: 29
					}, {
						Level: 36,
						req1: 58,
						req2: 34
					}, {
						Level: 42,
						req1: 67,
						req2: 39
					}, {
						Level: 48,
						req1: 76,
						req2: 45
					}, {
						Level: 54,
						req1: 85,
						req2: 50
					}, {
						Level: 60,
						req1: 94,
						req2: 56
					}, {
						Level: 66,
						req1: 103,
						req2: 61
					}, {
						Level: 72,
						req1: 112,
						req2: 66
					}, {
						Level: 78,
						req1: 121,
						req2: 72
					}, {
						Level: 85,
						req1: 132,
						req2: 78
					}, {
						Level: 95,
						req1: 147,
						req2: 87
					}, {
						Level: 105,
						req1: 162,
						req2: 96
					}, {
						Level: 115,
						req1: 177,
						req2: 105
					}, {
						Level: 130,
						req1: 199,
						req2: 119
					}, {
						Level: 145,
						req1: 222,
						req2: 132
					}, {
						Level: 160,
						req1: 244,
						req2: 146
					}, {
						Level: 170,
						req1: 259,
						req2: 155
					}
				]};
				break;
				
			case Weapons.Type.BigMace:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 19,
						req2: 8
					}, {
						Level: 16,
						req1: 40,
						req2: 15
					}, {
						Level: 24,
						req1: 58,
						req2: 22
					}, {
						Level: 32,
						req1: 77,
						req2: 29
					}, {
						Level: 40,
						req1: 95,
						req2: 35
					}, {
						Level: 48,
						req1: 114,
						req2: 42
					}, {
						Level: 54,
						req1: 127,
						req2: 47
					}, {
						Level: 60,
						req1: 141,
						req2: 52
					}, {
						Level: 66,
						req1: 155,
						req2: 57
					}, {
						Level: 72,
						req1: 169,
						req2: 62
					}, {
						Level: 78,
						req1: 183,
						req2: 67
					}, {
						Level: 85,
						req1: 199,
						req2: 73
					}, {
						Level: 95,
						req1: 222,
						req2: 81
					}, {
						Level: 105,
						req1: 245,
						req2: 90
					}, {
						Level: 115,
						req1: 268,
						req2: 98
					}, {
						Level: 130,
						req1: 302,
						req2: 111
					}, {
						Level: 145,
						req1: 337,
						req2: 123
					}, {
						Level: 160,
						req1: 371,
						req2: 136
					}, {
						Level: 170,
						req1: 394,
						req2: 144
					}
				]};
				break;

			case Weapons.Type.Bow:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 4,
						req2: 20
					}, {
						Level: 12,
						req1: 5,
						req2: 31
					}, {
						Level: 18,
						req1: 6,
						req2: 44
					}, {
						Level: 24,
						req1: 7,
						req2: 57
					}, {
						Level: 30,
						req1: 8,
						req2: 70
					}, {
						Level: 36,
						req1: 10,
						req2: 84
					}, {
						Level: 42,
						req1: 11,
						req2: 97
					}, {
						Level: 48,
						req1: 12,
						req2: 110
					}, {
						Level: 54,
						req1: 13,
						req2: 123
					}, {
						Level: 60,
						req1: 14,
						req2: 136
					}, {
						Level: 66,
						req1: 16,
						req2: 150
					}, {
						Level: 72,
						req1: 17,
						req2: 163
					}, {
						Level: 78,
						req1: 18,
						req2: 176
					}, {
						Level: 85,
						req1: 19,
						req2: 191
					}, {
						Level: 95,
						req1: 21,
						req2: 212
					}, {
						Level: 105,
						req1: 23,
						req2: 235
					}, {
						Level: 115,
						req1: 25,
						req2: 257
					}, {
						Level: 130,
						req1: 28,
						req2: 290
					}, {
						Level: 145,
						req1: 31,
						req2: 323
					}, {
						Level: 160,
						req1: 34,
						req2: 356
					}, {
						Level: 170,
						req1: 36,
						req2: 378
					}
				]};
				break;
				
			case Weapons.Type.XBow:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 5,
						req2: 20
					}, {
						Level: 12,
						req1: 7,
						req2: 32
					}, {
						Level: 18,
						req1: 9,
						req2: 46
					}, {
						Level: 24,
						req1: 12,
						req2: 59
					}, {
						Level: 30,
						req1: 14,
						req2: 73
					}, {
						Level: 36,
						req1: 17,
						req2: 87
					}, {
						Level: 42,
						req1: 19,
						req2: 101
					}, {
						Level: 48,
						req1: 21,
						req2: 121
					}, {
						Level: 54,
						req1: 24,
						req2: 128
					}, {
						Level: 60,
						req1: 26,
						req2: 142
					}, {
						Level: 66,
						req1: 29,
						req2: 156
					}, {
						Level: 72,
						req1: 31,
						req2: 170
					}, {
						Level: 78,
						req1: 33,
						req2: 184
					}, {
						Level: 85,
						req1: 36,
						req2: 200
					}, {
						Level: 95,
						req1: 40,
						req2: 223
					}, {
						Level: 105,
						req1: 44,
						req2: 246
					}, {
						Level: 115,
						req1: 48,
						req2: 269
					}, {
						Level: 130,
						req1: 54,
						req2: 303
					}, {
						Level: 145,
						req1: 60,
						req2: 338
					}, {
						Level: 160,
						req1: 66,
						req2: 372
					}, {
						Level: 170,
						req1: 70,
						req2: 395
					}
				]};
				break;
				
			case Weapons.Type.Wand:
				return {
					Req1: "Strength",
					Req2: "Spirit",
					Reqs: [{
						Level: 7,
						req1: 3,
						req2: 23
					}, {
						Level: 12,
						req1: 4,
						req2: 36
					}, {
						Level: 18,
						req1: 5,
						req2: 52
					}, {
						Level: 24,
						req1: 6,
						req2: 67
					}, {
						Level: 30,
						req1: 7,
						req2: 83
					}, {
						Level: 36,
						req1: 9,
						req2: 98
					}, {
						Level: 42,
						req1: 10,
						req2: 114
					}, {
						Level: 48,
						req1: 11,
						req2: 130
					}, {
						Level: 54,
						req1: 12,
						req2: 145
					}, {
						Level: 60,
						req1: 13,
						req2: 161
					}, {
						Level: 66,
						req1: 15,
						req2: 177
					}, {
						Level: 72,
						req1: 16,
						req2: 192
					}, {
						Level: 78,
						req1: 17,
						req2: 206
					}, {
						Level: 85,
						req1: 18,
						req2: 226
					}, {
						Level: 95,
						req1: 20,
						req2: 252
					}, {
						Level: 105,
						req1: 22,
						req2: 278
					}, {
						Level: 115,
						req1: 24,
						req2: 304
					}, {
						Level: 130,
						req1: 27,
						req2: 343
					}, {
						Level: 145,
						req1: 30,
						req2: 382
					}, {
						Level: 160,
						req1: 33,
						req2: 421
					}, {
						Level: 170,
						req1: 35,
						req2: 447
					}
				]};
				break;
				
			case Weapons.Type.Staff:
				return {
					Req1: "Strength",
					Req2: "Spirit",
					Reqs: [{
						Level: 7,
						req1: 5,
						req2: 19
					}, {
						Level: 12,
						req1: 7,
						req2: 31
					}, {
						Level: 18,
						req1: 10,
						req2: 46
					}, {
						Level: 24,
						req1: 13,
						req2: 61
					}, {
						Level: 30,
						req1: 16,
						req2: 76
					}, {
						Level: 36,
						req1: 19,
						req2: 91
					}, {
						Level: 42,
						req1: 22,
						req2: 106
					}, {
						Level: 48,
						req1: 25,
						req2: 121
					}, {
						Level: 54,
						req1: 28,
						req2: 136
					}, {
						Level: 60,
						req1: 31,
						req2: 151
					}, {
						Level: 66,
						req1: 34,
						req2: 166
					}, {
						Level: 72,
						req1: 37,
						req2: 181
					}, {
						Level: 78,
						req1: 40,
						req2: 196
					}, {
						Level: 85,
						req1: 44,
						req2: 214
					}, {
						Level: 95,
						req1: 49,
						req2: 239
					}, {
						Level: 105,
						req1: 54,
						req2: 264
					}, {
						Level: 115,
						req1: 59,
						req2: 289
					}, {
						Level: 130,
						req1: 66,
						req2: 326
					}, {
						Level: 145,
						req1: 74,
						req2: 364
					}, {
						Level: 160,
						req1: 81,
						req2: 401
					}, {
						Level: 170,
						req1: 86,
						req2: 426
					}
				]};
				break;
				
			case Weapons.Type.TwinBlade:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 13,
						req2: 5
					}, {
						Level: 12,
						req1: 20,
						req2: 8
					}, {
						Level: 18,
						req1: 28,
						req2: 12
					}, {
						Level: 24,
						req1: 37,
						req2: 15
					}, {
						Level: 30,
						req1: 45,
						req2: 19
					}, {
						Level: 36,
						req1: 54,
						req2: 23
					}, {
						Level: 42,
						req1: 62,
						req2: 26
					}, {
						Level: 48,
						req1: 70,
						req2: 30
					}, {
						Level: 54,
						req1: 79,
						req2: 33
					}, {
						Level: 60,
						req1: 87,
						req2: 37
					}, {
						Level: 66,
						req1: 96,
						req2: 41
					}, {
						Level: 72,
						req1: 104,
						req2: 44
					}, {
						Level: 78,
						req1: 112,
						req2: 48
					}, {
						Level: 85,
						req1: 122,
						req2: 52
					}, {
						Level: 95,
						req1: 136,
						req2: 58
					}, {
						Level: 105,
						req1: 150,
						req2: 64
					}, {
						Level: 115,
						req1: 164,
						req2: 70
					}, {
						Level: 130,
						req1: 185,
						req2: 79
					}, {
						Level: 145,
						req1: 206,
						req2: 88
					}, {
						Level: 160,
						req1: 227,
						req2: 97
					}, {
						Level: 170,
						req1: 241,
						req2: 108
					}
				]};
				break;
				
			case Weapons.Type.Whip:
				return {
					Req1: "Dex",
					Req2: "Spirit",
					Reqs: [{
						Level: 7,
						req1: 8,
						req2: 15
					}, {
						Level: 12,
						req1: 12,
						req2: 24
					}, {
						Level: 18,
						req1: 17,
						req2: 35
					}, {
						Level: 24,
						req1: 22,
						req2: 46
					}, {
						Level: 30,
						req1: 27,
						req2: 57
					}, {
						Level: 36,
						req1: 32,
						req2: 68
					}, {
						Level: 42,
						req1: 36,
						req2: 78
					}, {
						Level: 48,
						req1: 41,
						req2: 89
					}, {
						Level: 54,
						req1: 46,
						req2: 100
					}, {
						Level: 60,
						req1: 51,
						req2: 111
					}, {
						Level: 66,
						req1: 55,
						req2: 122
					}, {
						Level: 72,
						req1: 60,
						req2: 132
					}, {
						Level: 78,
						req1: 65,
						req2: 143
					}, {
						Level: 85,
						req1: 71,
						req2: 156
					}, {
						Level: 95,
						req1: 79,
						req2: 174
					}, {
						Level: 105,
						req1: 87,
						req2: 192
					}, {
						Level: 115,
						req1: 95,
						req2: 210
					}, {
						Level: 130,
						req1: 107,
						req2: 237
					}, {
						Level: 145,
						req1: 119,
						req2: 264
					}, {
						Level: 160,
						req1: 131,
						req2: 291
					}, {
						Level: 170,
						req1: 139,
						req2: 309
					}
				]};
				break;
				
			case Weapons.Type.BagiPowa:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 13,
						req2: 6
					}, {
						Level: 12,
						req1: 20,
						req2: 9
					}, {
						Level: 18,
						req1: 28,
						req2: 13
					}, {
						Level: 24,
						req1: 37,
						req2: 16
					}, {
						Level: 30,
						req1: 45,
						req2: 20
					}, {
						Level: 36,
						req1: 54,
						req2: 24
					}, {
						Level: 42,
						req1: 62,
						req2: 27
					}, {
						Level: 48,
						req1: 70,
						req2: 31
					}, {
						Level: 54,
						req1: 79,
						req2: 34
					}, {
						Level: 60,
						req1: 87,
						req2: 38
					}, {
						Level: 66,
						req1: 96,
						req2: 42
					}, {
						Level: 72,
						req1: 104,
						req2: 45
					}, {
						Level: 78,
						req1: 112,
						req2: 49
					}, {
						Level: 85,
						req1: 122,
						req2: 53
					}, {
						Level: 95,
						req1: 136,
						req2: 59
					}, {
						Level: 105,
						req1: 150,
						req2: 65
					}, {
						Level: 115,
						req1: 164,
						req2: 71
					}, {
						Level: 130,
						req1: 185,
						req2: 80
					}, {
						Level: 145,
						req1: 206,
						req2: 89
					}, {
						Level: 160,
						req1: 227,
						req2: 98
					}, {
						Level: 170,
						req1: 241,
						req2: 104
					}
				]};
				break;
			
			case Weapons.Type.Spear:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 7,
						req1: 14,
						req2: 10
					}, {
						Level: 12,
						req1: 22,
						req2: 15
					}, {
						Level: 18,
						req1: 32,
						req2: 21
					}, {
						Level: 24,
						req1: 41,
						req2: 27
					}, {
						Level: 30,
						req1: 51,
						req2: 33
					}, {
						Level: 36,
						req1: 61,
						req2: 39
					}, {
						Level: 42,
						req1: 70,
						req2: 45
					}, {
						Level: 48,
						req1: 80,
						req2: 51
					}, {
						Level: 54,
						req1: 89,
						req2: 67
					}, {
						Level: 60,
						req1: 99,
						req2: 63
					}, {
						Level: 66,
						req1: 109,
						req2: 69
					}, {
						Level: 72,
						req1: 118,
						req2: 75
					}, {
						Level: 78,
						req1: 128,
						req2: 81
					}, {
						Level: 85,
						req1: 139,
						req2: 88
					}, {
						Level: 95,
						req1: 155,
						req2: 98
					}, {
						Level: 105,
						req1: 171,
						req2: 108
					}, {
						Level: 115,
						req1: 187,
						req2: 118
					}, {
						Level: 130,
						req1: 211,
						req2: 133
					}, {
						Level: 145,
						req1: 235,
						req2: 148
					}, {
						Level: 160,
						req1: 259,
						req2: 163
					}, {
						Level: 170,
						req1: 275,
						req2: 173
					}
				]};
				break;
				
			case Weapons.Type.ConcerraTwinBlade:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 13,
						req1: 9,
						req2: 29
					}, {
						Level: 25,
						req1: 15,
						req2: 52
					}, {
						Level: 37,
						req1: 21,
						req2: 75
					}, {
						Level: 49,
						req1: 27,
						req2: 98
					}, {
						Level: 61,
						req1: 33,
						req2: 121
					}, {
						Level: 73,
						req1: 39,
						req2: 143
					}, {
						Level: 85,
						req1: 45,
						req2: 166
					}, {
						Level: 95,
						req1: 50,
						req2: 185
					}, {
						Level: 105,
						req1: 55,
						req2: 204
					}, {
						Level: 115,
						req1: 60,
						req2: 223
					}, {
						Level: 130,
						req1: 67,
						req2: 252
					}, {
						Level: 145,
						req1: 75,
						req2: 280
					}, {
						Level: 160,
						req1: 82,
						req2: 309
					}, {
						Level: 170,
						req1: 87,
						req2: 328
					}]};
				break;
				
			case Weapons.Type.Scythe:
				return {
					Req1: "Strength",
					Req2: "Spirit",
					Reqs: [{
						Level: 13,
						req1: 20,
						req2: 18
					}, {
						Level: 25,
						req1: 36,
						req2: 32
					}, {
						Level: 37,
						req1: 51,
						req2: 47
					}, {
						Level: 49,
						req1: 67,
						req2: 61
					}, {
						Level: 61,
						req1: 82,
						req2: 76
					}, {
						Level: 73,
						req1: 98,
						req2: 90
					}, {
						Level: 85,
						req1: 114,
						req2: 104
					}, {
						Level: 95,
						req1: 127,
						req2: 116
					}, {
						Level: 105,
						req1: 140,
						req2: 128
					}, {
						Level: 115,
						req1: 153,
						req2: 140
					}, {
						Level: 130,
						req1: 172,
						req2: 158
					}, {
						Level: 145,
						req1: 192,
						req2: 176
					}, {
						Level: 160,
						req1: 211,
						req2: 194
					}, {
						Level: 170,
						req1: 224,
						req2: 206
					}]};
				break;
				
			case Weapons.Type.Orb:
				return {
					Req1: "Strength",
					Req2: "Spirit",
					Reqs: [{
						Level: 13,
						req1: 4,
						req2: 39
					}, {
						Level: 25,
						req1: 6,
						req2: 70
					}, {
						Level: 37,
						req1: 9,
						req2: 101
					}, {
						Level: 49,
						req1: 11,
						req2: 132
					}, {
						Level: 61,
						req1: 14,
						req2: 164
					}, {
						Level: 73,
						req1: 16,
						req2: 195
					}, {
						Level: 85,
						req1: 18,
						req2: 226
					}, {
						Level: 95,
						req1: 20,
						req2: 252
					}, {
						Level: 105,
						req1: 22,
						req2: 278
					}, {
						Level: 115,
						req1: 24,
						req2: 304
					}, {
						Level: 130,
						req1: 27,
						req2: 343
					}, {
						Level: 145,
						req1: 30,
						req2: 382
					}, {
						Level: 160,
						req1: 33,
						req2: 421
					}, {
						Level: 170,
						req1: 35,
						req2: 447
					}]};
				break;
				
			case Weapons.Type.Falcion:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 13,
						req1: 26,
						req2: 9
					}, {
						Level: 25,
						req1: 48,
						req2: 15
					}, {
						Level: 37,
						req1: 69,
						req2: 21
					}, {
						Level: 49,
						req1: 91,
						req2: 27
					}, {
						Level: 61,
						req1: 113,
						req2: 33
					}, {
						Level: 73,
						req1: 134,
						req2: 39
					}, {
						Level: 85,
						req1: 156,
						req2: 45
					}, {
						Level: 95,
						req1: 174,
						req2: 50
					}, {
						Level: 105,
						req1: 192,
						req2: 55
					}, {
						Level: 115,
						req1: 210,
						req2: 60
					}, {
						Level: 130,
						req1: 237,
						req2: 67
					}, {
						Level: 145,
						req1: 264,
						req2: 75
					}, {
						Level: 160,
						req1: 291,
						req2: 82
					}, {
						Level: 170,
						req1: 309,
						req2: 87
					}]};
				break;
				
			case Weapons.Type.Claw:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 13,
						req1: 17,
						req2: 17
					}, {
						Level: 25,
						req1: 29,
						req2: 31
					}, {
						Level: 37,
						req1: 41,
						req2: 46
					}, {
						Level: 49,
						req1: 53,
						req2: 60
					}, {
						Level: 61,
						req1: 65,
						req2: 75
					}, {
						Level: 73,
						req1: 77,
						req2: 89
					}, {
						Level: 85,
						req1: 89,
						req2: 103
					}, {
						Level: 95,
						req1: 99,
						req2: 115
					}, {
						Level: 105,
						req1: 109,
						req2: 127
					}, {
						Level: 115,
						req1: 119,
						req2: 139
					}, {
						Level: 130,
						req1: 134,
						req2: 157
					}, {
						Level: 145,
						req1: 149,
						req2: 175
					}, {
						Level: 160,
						req1: 164,
						req2: 193
					}, {
						Level: 170,
						req1: 174,
						req2: 205
					}]};
				break;
				
			case Weapons.Type.Hammer:
				return {
					Req1: "Strength",
					Req2: "Dex",
					Reqs: [{
						Level: 13,
						req1: 28,
						req2: 9
					}, {
						Level: 25,
						req1: 51,
						req2: 15
					}, {
						Level: 37,
						req1: 74,
						req2: 21
					}, {
						Level: 49,
						req1: 97,
						req2: 27
					}, {
						Level: 61,
						req1: 120,
						req2: 33
					}, {
						Level: 73,
						req1: 142,
						req2: 39
					}, {
						Level: 85,
						req1: 165,
						req2: 45
					}, {
						Level: 95,
						req1: 184,
						req2: 50
					}, {
						Level: 105,
						req1: 203,
						req2: 55
					}, {
						Level: 115,
						req1: 222,
						req2: 60
					}, {
						Level: 130,
						req1: 251,
						req2: 67
					}, {
						Level: 145,
						req1: 279,
						req2: 75
					}, {
						Level: 160,
						req1: 308,
						req2: 82
					}, {
						Level: 170,
						req1: 327,
						req2: 87
					}, {
						Level: 180,
						req1: 346,
						req2: 92
					}]};
				break;
		}
	}
}