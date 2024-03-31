import Navbar from "../components/Navbar";
import Grid from "@mui/material/Grid";
import LocationOnIcon from "@mui/icons-material/LocationOn";
import Input from "@mui/material/Input";
import InputLabel from "@mui/material/InputLabel";
import { useState, useEffect } from "react";
import styles from "../styles/HomePage.module.scss";
export default function HomePage() {
  const [backgroundImage, setBackgroundImage] = useState("https://i.pinimg.com/originals/d9/30/ec/d930ec2f92d552f93dcf7789e3dc6f2f.jpg");
  useEffect(() => {
    const timeout = setTimeout(() => {
      setBackgroundImage("https://i.pinimg.com/originals/d9/30/ec/d930ec2f92d552f93dcf7789e3dc6f2f.jpg");
    }, 5000);
    return () => clearTimeout(timeout);
  }, []);
  return (
    <>
      <Navbar />
      <div className={styles.banner}>
        <div className={styles.banner_image} style={{ backgroundImage: `url(${backgroundImage})` }}>
          <div className={styles.content}>
            <Grid container>
              <Grid item xs={12} md={4} className={styles.content_details}>
                <LocationOnIcon />
                <div>
                  <InputLabel htmlFor="input-with-icon-adornment">With a start adornment</InputLabel>
                  <Input id="input-with-icon-adornment" />
                </div>
              </Grid>
              <Grid item xs={12} md={3} className={styles.content_details}>
                <LocationOnIcon />
                <div>
                  <InputLabel htmlFor="input-with-icon-adornment">With a start adornment</InputLabel>
                  <Input id="input-with-icon-adornment" />
                </div>
              </Grid>
              <Grid item xs={12} md={3} className={styles.content_details}>
                <LocationOnIcon />
                <div>
                  <InputLabel htmlFor="input-with-icon-adornment">With a start adornment</InputLabel>
                  <Input id="input-with-icon-adornment" />
                </div>
              </Grid>
              <Grid item xs={12} md={2}>
                <div>BOOK NOW</div>
              </Grid>
            </Grid>
          </div>
        </div>
      </div>
    </>
  );
}
