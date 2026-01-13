import jwt from "jsonwebtoken";

const authMiddleware = (req, res, next) => {
    const authHeader = req.headers['authorization'];
    const token = authHeader && authHeader.split(' ')[1]; // Lấy token sau Bearer

    if (!token) return res.status(401).json({ msg: "Không có token, quyền truy cập bị từ chối" });

    jwt.verify(token, process.env.JWT_SECRET || 'secret_key', (err, decoded) => {
        if (err) return res.status(403).json({ msg: "Token không hợp lệ hoặc đã hết hạn" });
        req.user = decoded;
        next();
    });
};

export default authMiddleware;