import express from "express";
import bcrypt from "bcrypt";
import jwt from "jsonwebtoken";
// Sửa lỗi: Phải có đuôi .js ở cuối đường dẫn
import pool from "../db/db.js"; 
import authMiddleware from "../middleware/auth.js";

const router = express.Router();

// --- Task của bạn: Endpoint /me ---
router.get("/me", authMiddleware, async (req, res) => {
    try {
        // req.user được truyền từ middleware auth.js sau khi verify token
        res.status(200).json({
            success: true,
            user: req.user 
        });
    } catch (error) {
        res.status(500).json({ msg: "Lỗi server" });
    }
});

// Các route khác chuyển sang kiểu ES Module
router.post("/register", async (req, res) => {
    // Giữ nguyên logic cũ nhưng dùng import/export
});

export default router;