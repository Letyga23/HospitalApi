using Azure;
using HospitalApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace HospitalApi.Controllers
{
    public class PatientController : Controller
    {
        // GET: /Patients
        [HttpGet, Route("Patient")]
        public IEnumerable<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            List<object[]> responsePatients = DataBaseWorker.ExecuteQueryObject("SELECT * FROM Patients", 11);

            foreach (object[] patient in responsePatients)
                patients.Add(new Patient(patient));

            return patients;
        }

        // GET: /Patients/1
        [HttpGet, Route("Patient/{id}")]
        public Patient GetPatients(int id)
        {
            List<object[]> responsePatients = DataBaseWorker.ExecuteQueryObject($"SELECT * FROM Patients WHERE Id_Patient = {id}", 11); ;
            Patient patient = new Patient(responsePatients[0]);
            return patient;
        }

        [HttpPut, Route("Patient/Put/{id}")]
        public IActionResult PutPatient(int id, [FromBody] Patient updatedPatient)
        {
            List<object[]> responsePatients = DataBaseWorker.ExecuteQueryObject($"SELECT * FROM Patients WHERE Id_Patient = {id}", 11);

            if (responsePatients == null || responsePatients.Count == 0)
                return BadRequest("Не корректный Id_Patient");

            // Обновляем информацию о пациенте
            string updateQuery = $"UPDATE Patients SET LastName = N'{updatedPatient.LastName}', " +
                                 $"FirstName = N'{updatedPatient.FirstName}', " +
                                 $"Patronymic = N'{updatedPatient.Patronymic}', " +
                                 $"PassportData = N'{updatedPatient.PassportData}', " +
                                 $"DateOfBirth = '{updatedPatient.DateOfBirth}', " +
                                 $"Gender = N'{updatedPatient.Gender}', " +
                                 $"Address = N'{updatedPatient.Address}', " +
                                 $"PhoneNumber = N'{updatedPatient.PhoneNumber}', " +
                                 $"Email = N'{updatedPatient.Email}' " +
                                 $"WHERE Id_Patient = {id}";

            try
            {
                DataBaseWorker.ExecuteQueryWithoutResponse(updateQuery);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

            return Ok("Данные изменены");
        }

        [HttpPost, Route("Patient/Post")]
        public IActionResult PostPatient([FromBody] Patient insertPatient)
        {
            if (insertPatient == null)
                return BadRequest("Не корректные данные");


            string insertQuery = $"INSERT INTO Patients (LastName, FirstName, Patronymic, PassportData, DateOfBirth, Gender, Address, PhoneNumber, Email, PatientPhoto) " +
                     $"VALUES (N'{insertPatient.LastName}', " +
                     $"N'{insertPatient.FirstName}', " +
                     $"N'{insertPatient.Patronymic}', " +
                     $"N'{insertPatient.PassportData}', " +
                     $"'{insertPatient.DateOfBirth}', " +
                     $"N'{insertPatient.Gender}', " +
                     $"N'{insertPatient.Address}', " +
                     $"N'{insertPatient.PhoneNumber}', " +
                     $"N'{insertPatient.Email}', " +
                     "null)";

            try
            {
                DataBaseWorker.ExecuteQueryWithoutResponse(insertQuery);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }

            return Ok("Пациент добавлен");
        }

        [HttpDelete, Route("Patient/Delete/{id}")]
        public IActionResult DeletePatient(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid patient ID");

            string deleteQuery = $"DELETE FROM Patients WHERE Id_Patient = {id}";

            try
            {
                DataBaseWorker.ExecuteQueryWithoutResponse(deleteQuery);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting patient: {ex.Message}");
            }

            return Ok("Пациент удалён");
        }

    }
}
