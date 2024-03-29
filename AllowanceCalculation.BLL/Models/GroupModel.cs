﻿namespace AllowanceCalculation.BLL.Models;

public class GroupModel
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public List<StudentModel> Students { get; set; } = new();

	public List<GroupSubjectModel> GroupSubjects { get; set; } = new();
}