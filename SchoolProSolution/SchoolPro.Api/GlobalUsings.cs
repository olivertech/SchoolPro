﻿global using Microsoft.AspNetCore.Mvc;
global using AutoMapper;
global using SchoolPro.Infra.Dependencies;
global using System.Text.Json;
global using FluentValidation;
global using SchoolPro.Core.Interfaces;
global using SchoolPro.Shared.Requests;
global using Microsoft.IdentityModel.Tokens;
global using SchoolPro.Core.Entities;
global using SchoolPro.Shared.Configurations;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using Microsoft.AspNetCore.Authorization;
global using SchoolPro.Api.Auth;
global using SchoolPro.Shared.Responses;
global using SchoolPro.Shared.Responses.Factory;
global using SchoolPro.Shared.Dependencies;
global using Microsoft.AspNetCore.Mvc.Filters;
global using SchoolPro.Api.Cache;
global using Microsoft.AspNetCore.Authentication;
global using System.Runtime.Caching;