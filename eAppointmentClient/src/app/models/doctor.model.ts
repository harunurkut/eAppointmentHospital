export class DoctorModel{
    id:string="";
    firstName:string ="";
    lastName:string ="";
    fullName:string="";
    department:DepartmentModel | any = new DepartmentModel();
   departmentValue: number = 0;
}
export class DepartmentModel{
    name:string="";
    value:number=0;
}