/** @type {import('next').NextConfig} */
const nextConfig = {
  distDir: "build",
  i18n: {
    locales: ["en-US", "fi"],
    defaultLocale: "en-US",
  },
};

export default nextConfig;
