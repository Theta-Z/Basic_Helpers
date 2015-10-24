function LoadWeaponGrid(vm){
	var weaponStats = Weapons.Get(vm.selectedWeapon().wid);
	
	$.jgrid.gridUnload("jqGrid");
	
	if(vm.selectedWeapon().wid == 0) return;
	
	$("#jqGrid").jqGrid({
		data: weaponStats.Reqs,
		datatype: 'local',
		width: 300,
		colNames: ["Level", weaponStats.Req1, weaponStats.Req2],
		colModel: [
			{name:"Level", index:"Level", width:100, align:"center"},
			{name:"req1",  index:"req1",  width:100, align:"center"},
			{name:"req2",  index:"req2",  width:100, align:"center"}
		],
		rowNum: 25
	});
	
	$("#gridHeader").show();
}

function WeaponModel(info){
	var self = this;
	self.wid = info.wid;
	self.weaponName = info.weaponName;
}

function WeaponViewModel(){
	var self = this;
	var weapons = Weapons.GetWeaponList();
	
	self.weaponList = ko.observableArray();
	self.selectedWeapon = ko.observable();
	
	self.weaponList.push({
		wid: 0,
		weaponName: "<Choose>"
	});
	
	$.each(weapons, function(i, info){
		self.weaponList.push(new WeaponModel(info));
	});
	
	self.selectedWeapon.subscribe(function(val){
		console.log(val);
		if(val.wid != 0)
			LoadWeaponGrid(self);
	});
}

$(document).ready(function(){
	var vm = new WeaponViewModel();
	ko.applyBindings(vm);
	$("#gridHeader").hide();
});