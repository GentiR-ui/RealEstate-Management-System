using System;

namespace RealEstate.Domain.Entities;

public class UserRole { public int UserId { get; set; } public int RoleId { get; set; } public DateTime AssignedAt { get; set; } = DateTime.UtcNow; }
public class Permission { public int Id { get; set; } public string Name { get; set; } = string.Empty; public string Description { get; set; } = string.Empty; }
public class RolePermission { public int RoleId { get; set; } public int PermissionId { get; set; } }
public class RefreshToken { public int Id { get; set; } public int UserId { get; set; } public string TokenHash { get; set; } = string.Empty; public DateTime ExpiresAt { get; set; } public DateTime? RevokedAt { get; set; } public DateTime CreatedAt { get; set; } = DateTime.UtcNow; }
public class AuditLog { public int Id { get; set; } public int UserId { get; set; } public string Action { get; set; } = string.Empty; public string Entity { get; set; } = string.Empty; public int EntityId { get; set; } public string OldValue { get; set; } = string.Empty; public string NewValue { get; set; } = string.Empty; public string IpAddress { get; set; } = string.Empty; public DateTime CreatedAt { get; set; } = DateTime.UtcNow; }
public class Notification { public int Id { get; set; } public int UserId { get; set; } public string Type { get; set; } = string.Empty; public string Title { get; set; } = string.Empty; public string Message { get; set; } = string.Empty; public bool IsRead { get; set; } public DateTime CreatedAt { get; set; } = DateTime.UtcNow; }
public class Setting { public int Id { get; set; } public string Key { get; set; } = string.Empty; public string Value { get; set; } = string.Empty; public string Description { get; set; } = string.Empty; public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; }
public class SystemFile { public int Id { get; set; } public string Entity { get; set; } = string.Empty; public int EntityId { get; set; } public string Filename { get; set; } = string.Empty; public string FilePath { get; set; } = string.Empty; public long FileSize { get; set; } public int UploadedBy { get; set; } public DateTime CreatedAt { get; set; } = DateTime.UtcNow; }
