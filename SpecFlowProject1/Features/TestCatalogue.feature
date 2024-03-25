Feature: Test and Lab addition

   Scenario:1Login
      Given launch URL
      When enter username and login
      Then user should view company window
      When user select a company
      Then user should view selected company name on top right side
      
    Scenario:2Add Test
      When user added Test details
      Then Test is saved

    Scenario:3Add Lab
      When user added Lab details
      Then Details of lab are saved

   