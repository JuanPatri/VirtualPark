## Main
![Build - Test - Main](https://github.com/IngSoft-DA2/266824_329180_287195/actions/workflows/build-test.yml/badge.svg?branch=main&event=push)
![Clean Code - Main](https://github.com/IngSoft-DA2/266824_329180_287195/actions/workflows/code-analysis.yml/badge.svg?branch=main&event=push)

## Develop
![Build - Test - Develop](https://github.com/IngSoft-DA2/266824_329180_287195/actions/workflows/build-test.yml/badge.svg?branch=develop&event=push)
![Clean Code - Develop](https://github.com/IngSoft-DA2/266824_329180_287195/actions/workflows/code-analysis.yml/badge.svg?branch=develop&event=push)


VirtualPark

VirtualPark is a full-stack academic project developed during the Design of Applications 2 course. The system represents a virtual theme park management platform that supports administration, daily operations, and visitor interaction, including a gamification mechanism based on configurable scoring strategies.

The project was built with a strong focus on software architecture, clean design, and maintainability, applying the main concepts and best practices covered throughout the course.

Overview

The system follows a client–server architecture composed of an ASP.NET Web API backend and an Angular frontend. Communication between client and server is implemented through a RESTful API using JSON, while data persistence is handled with SQL Server and Entity Framework Core.

VirtualPark supports multiple user roles, such as administrators, attraction operators, and visitors. Visitors can register, purchase tickets, record visits, earn points, view rankings, and redeem rewards. Administrators can manage attractions, events, users, roles, permissions, and configure the active gamification strategy.

Architecture and Design

The backend is structured using a layered architecture, clearly separating presentation, business logic, and data access. Dependency Injection is used throughout the solution, with a dedicated composition root to enforce the Dependency Inversion Principle and avoid tight coupling between layers.

The system applies Clean Code, SOLID principles, and GRASP, resulting in classes with single responsibilities, high cohesion, and low coupling. Business logic depends exclusively on abstractions, allowing the infrastructure layer to be replaced or modified without impacting the core domain.

Several design patterns are used, most notably Strategy and Factory, to implement an extensible gamification system. Scoring strategies can be dynamically loaded and changed without modifying existing code, enabling flexible evolution of the system.

REST API

The API was designed according to REST principles, ensuring a uniform interface, stateless communication, proper use of HTTP methods, and meaningful status codes. Authentication is handled using token-based mechanisms, with each request carrying the required authorization information.

The API exposes endpoints for managing users, roles, permissions, attractions, events, tickets, visits, rankings, rewards, and scoring strategies.

Frontend

The frontend was developed using Angular, following a clear separation between components, services, and models. It consumes the REST API and focuses exclusively on presentation and user interaction, delegating all business logic to the backend.

This approach keeps the client lightweight and allows the backend to be reused by other potential clients.

Testing and TDD

The development process was guided by Test-Driven Development (TDD). Unit tests were written before implementing functionality, helping to define expected behavior, detect design issues early, and support safe refactoring.

Tests cover the main layers of the system and make extensive use of mocks and abstractions to isolate components and validate business rules independently of infrastructure concerns.

Technologies Used

ASP.NET Web API

Angular

SQL Server

Entity Framework Core

RESTful APIs

Test-Driven Development (TDD)

Clean Code and SOLID principles

Purpose

This project was developed for academic purposes as part of the Design of Applications 2 course. Its main goal is to demonstrate the practical application of software design principles, architectural patterns, and testing strategies in a real-world style system.
